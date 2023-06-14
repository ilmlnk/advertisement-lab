import { render, screen, fireEvent, act } from '@testing-library/react';
import axios from 'axios';
import AdvertisementList from '../AdvertisementList';

jest.mock('axios');

describe('AdvertisementList', () => {
  const mockData = [
    {
        id: 1,
        systemUserId: 123,
        description: 'Test ad 1',
        name: 'Ad 1',
        topic: 'Test topic',
        price: 100,
      },
      {
        id: 2,
        systemUserId: 456,
        description: 'Test ad 2',
        name: 'Ad 2',
        topic: 'Test topic',
        price: 200,
      },
    ];


  beforeEach(() => {
    axios.get.mockResolvedValue({ data: mockData });
  });

  afterEach(() => {
    jest.clearAllMocks();
  });

  {/* checks for displaying advertisements  */}
  test('renders the component', async () => {
    render(<AdvertisementList/>);
    expect(screen.getByText('Advertisements')).toBeInTheDocument();
  })

  test('fetches data', async () => {
    axios.get.mockResolvedValue({ data: mockData });

    render(<AdvertisementList/>);

    expect(axios.get).toHaveBeenCalledWith(
      'https://localhost:50555/api/TelegramAdvertisement/telegram/ads'
    );
  });

  test('displaying "No Data" message', () => {
    expect(screen.getByText('No data')).toBeInTheDocument();
  });

  test('show data', async () => {
    axios.get.mockResolvedValueOnce({ data: mockData });

    render(<AdvertisementList />);
    await screen.findByText('Advertisements');
  });


  test('opens and closes the modal', async () => {
    render(<AdvertisementList/>);

    expect(screen.queryByRole('dialog')).toBeNull();

    const advertisement = screen.getByTestId('advertisement-0');
    fireEvent.click(advertisement);

    const modal = screen.getByRole('dialog');
    expect(modal).toBeInTheDocument();

    const closeButton = screen.getByText('Close');
    fireEvent.click(closeButton);

    expect(screen.queryByRole('dialog')).toBeNull();
  });

});