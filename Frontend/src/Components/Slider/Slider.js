import { forwardRef, cloneElement } from 'react';
import { Box } from '@chakra-ui/react';
import AliceCarousel from 'react-alice-carousel';
import 'react-alice-carousel/lib/alice-carousel.css';

const Slider = forwardRef(
  (
    {
      className,
      items,
      centerMode,
      magnifiedIndex = 0,
      activeSlideCSS = 'scale-75',
      ...props
    },
    ref
  ) => {
    const isSmall = (index) => {
      if (props?.activeIndex + magnifiedIndex >= items?.length) {
        return index !== props?.activeIndex + magnifiedIndex - items?.length;
      } else {
        return index !== props.activeIndex + magnifiedIndex;
      }
    };

    const slideItems = centerMode
      ? items.map((child, index) => {
          if (isSmall(index)) {
            return cloneElement(child, {
              ...child.props,
              className: [child.props?.className, activeSlideCSS]
                .filter(Boolean)
                .join(' '),
            });
          }
          return cloneElement(child);
        })
      : items;

    return (
      <Box className={className}>
        <AliceCarousel
          items={slideItems}
          disableDotsControls
          touchTracking
          disableButtonsControls
          infinite
          mouseTracking
          ref={ref}
          {...props}
        />
      </Box>
    );
  }
);

export default Slider;
