import {
  Box,
  Flex,
  Avatar,
  Link,
  Menu,
  MenuButton,
  MenuList,
  MenuItem,
  MenuDivider,
  useDisclosure,
  useColorMode,
  IconButton,
  CloseButton,
  Icon,
  Drawer,
  DrawerContent,
  Text,
  HStack,
  VStack,
  Heading,
  Button,
  Divider,
  Center,
  useColorModeValue
} from "@chakra-ui/react";

import {
  FiHome,
  FiTrendingUp,
  FiCompass,
  FiStar,
  FiSettings,
  FiMenu,
  FiBell,
  FiChevronDown,
  FiMessageCircle,
  FiDollarSign,
  FiUserCheck,
  FiUsers,
  FiSmile,
  FiMoon,
  FiSun,
  FiHeart,
  FiCalendar,
  FiGlobe,
} from "react-icons/fi";

import { BiUser } from "react-icons/bi";

import { IconType } from "react-icons";
import { ReactText } from "react";

import { MoonIcon, SunIcon } from "@chakra-ui/icons";
import Footer from "../footer/Footer.js";
import { Navigate, useNavigate } from "react-router-dom";

const LinkItems = [
  { name: "Home", icon: FiHome, navigation: "main" },
  { name: "Admin", icon: BiUser, navigation: "admin" },
  { name: "Analytics", icon: FiTrendingUp, navigation: "analytics" },
  { name: "Manage Users", icon: FiUsers, navigation: "user-management" },
  { name: "Manage Budget", icon: FiDollarSign, navigation: "budget-management" },
  { name: "Compliances", icon: FiUserCheck, navigation: "compliance-management" },
  { name: "Command Chat", icon: FiMessageCircle, navigation: "command-chat" },
  { name: "Customer Support", icon: FiSmile, navigation: "customer-support" },
];

const Notifications = [
  { user: "User", date: "01.01.1980 at 12:00 AM", text: "Lorem ipsum" },
  { user: "User 1", date: "01.01.1980 at 12:00 AM", text: "Lorem ipsum" },
  { user: "User 2", date: "01.01.1980 at 12:00 AM", text: "Lorem ipsum" },
  { user: "User 3", date: "01.01.1980 at 12:00 AM", text: "Lorem ipsum" },
];

const NavLink = ({ children }) => (
  <Link
    px={2}
    py={1}
    rounded={"md"}
    _hover={{
      textDecoration: "none",
      bg: useColorModeValue("gray.200", "gray.700"),
    }}
    href={"#"}
  >
    {children}
  </Link>
);

export default function SidebarWithHeader({ children }) {
  const { colorMode, toggleColorMode } = useColorMode();
  const { isOpen, onOpen, onClose } = useDisclosure();
  return (
    <>
      <Box minH="100vh" bg={useColorModeValue("gray.100", "gray.900")}>
        <SidebarContent
          onClose={() => onClose}
          display={{ base: "none", md: "block" }}
        />
        <Drawer
          autoFocus={false}
          isOpen={isOpen}
          placement="left"
          onClose={onClose}
          returnFocusOnClose={false}
          onOverlayClick={onClose}
          size="full"
        >
          <DrawerContent>
            <SidebarContent onClose={onClose} />
          </DrawerContent>
        </Drawer>
        {/* mobilenav */}
        <MobileNav onOpen={onOpen} />
        <Box ml={{ base: 0, md: 60 }} p="4">
          {children}
        </Box>
      </Box>
    </>
  );
}

const SidebarContent = ({ onClose, ...rest }) => {
  const navigate = useNavigate();
  return (
    <Box
      bg={useColorModeValue("white", "gray.900")}
      borderRight="1px"
      borderRightColor={useColorModeValue("gray.200", "gray.700")}
      w={{ base: "full", md: 60 }}
      pos="fixed"
      h="full"
      {...rest}
    >
      <Flex h="20" alignItems="center" mx="8" justifyContent="space-between">
        <Text fontSize="2xl" fontFamily="monospace" fontWeight="bold">
          Logo
        </Text>
        <CloseButton display={{ base: "flex", md: "none" }} onClick={onClose} />
      </Flex>
      {LinkItems.map((link) => (
        <NavItem onClick={() => navigate("/" + link.navigation)} key={link.name} icon={link.icon}>
          {link.name}
        </NavItem>
      ))}
    </Box>
  );
};

const NavItem = ({ icon, children, ...rest }) => {
  const navigate = useNavigate();
  return (
    <Link
      style={{ textDecoration: "none" }}
      _focus={{ boxShadow: "none" }}
    >
      <Flex
        align="center"
        p="4"
        mx="4"
        borderRadius="lg"
        role="group"
        cursor="pointer"
        _hover={{
          bg: "cyan.400",
          color: "white",
        }}
        {...rest}
      >
        {icon && (
          <Icon
            mr="4"
            fontSize="16"
            _groupHover={{
              color: "white",
            }}
            as={icon}
          />
        )}
        {children}
      </Flex>
    </Link>
  );
};

const MobileNav = ({ onOpen, ...rest }) => {
  const { colorMode, toggleColorMode } = useColorMode();
  const { isOpen, onClose } = useDisclosure();
  return (
    <Flex
      ml={{ base: 0, md: 60 }}
      px={{ base: 4, md: 4 }}
      height="20"
      alignItems="center"
      bg={useColorModeValue("white", "gray.900")}
      borderBottomWidth="1px"
      borderBottomColor={useColorModeValue("gray.200", "gray.700")}
      justifyContent={{ base: "space-between", md: "flex-end" }}
      {...rest}
    >
      <IconButton
        display={{ base: "flex", md: "none" }}
        onClick={onOpen}
        variant="outline"
        aria-label="open menu"
        icon={<FiMenu />}
      />

      <Text
        display={{ base: "flex", md: "none" }}
        fontSize="2xl"
        fontFamily="monospace"
        fontWeight="bold"
      >
        Logo
      </Text>

      <HStack spacing={{ base: "0", md: "6" }}>
        <IconButton
          onClick={toggleColorMode}
          size="lg"
          variant="ghost"
          aria-label="open menu"
        >
          {colorMode === "light" ? <FiMoon /> : <FiSun />}
        </IconButton>

        <Menu>
          <MenuButton
            as={IconButton}
            size="lg"
            variant="ghost"
            aria-label="open menu"
          >
            <FiGlobe
              style={{
                position: "absolute",
                top: "50%",
                left: "50%",
                transform: "translate(-50%, -50%)",
              }}
            />
          </MenuButton>
          <MenuList
            width="200px"
            maxH="400px"
            overflow="auto"
            bg={useColorModeValue("white", "gray.700")}
            borderColor={useColorModeValue("gray.200", "gray.900")}
          >
            <MenuItem>Ukrainian</MenuItem>
            <MenuItem>Polish</MenuItem>
            <MenuItem>English</MenuItem>
            <MenuItem>German</MenuItem>
          </MenuList>
        </Menu>

        <Menu>
          <MenuButton
            as={IconButton}
            size="lg"
            variant="ghost"
            aria-label="open menu"
          >
            <FiBell
              style={{
                position: "absolute",
                top: "50%",
                left: "50%",
                transform: "translate(-50%, -50%)",
              }}
            />
          </MenuButton>
          <MenuList
            width="400px"
            maxH="400px"
            overflow="auto"
            bg={useColorModeValue("white", "gray.700")}
            borderColor={useColorModeValue("gray.200", "gray.900")}
          >
            <Heading m={4} ml={6}>
              Notifications
            </Heading>
            <Box mb={2} ml={6}>
              <Heading size="md">Choose filter</Heading>
              <Box mt={2}>
                <Button w="78.5px" mr={2}>
                  <FiBell />
                </Button>
                <Button w="78.5px" mr={2}>
                  <FiMessageCircle />
                </Button>
                <Button w="78.5px" mr={2}>
                  <FiHeart />
                </Button>
                <Button w="78.5px" mr={2}>
                  <FiCalendar />
                </Button>
              </Box>
            </Box>
            <Divider />
            {Notifications.map((notification, index) => (
              <MenuItem key={index} mt={2}>
                <Box>
                  <Flex>
                    <Avatar w="30px" h="30px" m={2} />
                    <Heading size="lg">{notification.user}</Heading>
                  </Flex>
                  <Text>{notification.date}</Text>
                  <Text>{notification.text}</Text>
                </Box>
              </MenuItem>
            ))}
          </MenuList>
        </Menu>

        <Flex alignItems={"center"}>
          <Menu>
            <MenuButton
              py={2}
              transition="all 0.3s"
              _focus={{ boxShadow: "none" }}
            >
              <HStack>
                <Avatar
                  size={"sm"}
                  src={
                    "https://images.unsplash.com/photo-1619946794135-5bc917a27793?ixlib=rb-0.3.5&q=80&fm=jpg&crop=faces&fit=crop&h=200&w=200&s=b616b2c5b373a80ffc9636ba24f7a4a9"
                  }
                />
                <VStack
                  display={{ base: "none", md: "flex" }}
                  alignItems="flex-start"
                  spacing="1px"
                  ml="2"
                >
                  <Text fontSize="sm">Justina Clark</Text>
                  <Text fontSize="xs" color="gray.600">
                    Admin
                  </Text>
                </VStack>
                <Box display={{ base: "none", md: "flex" }}>
                  <FiChevronDown />
                </Box>
              </HStack>
            </MenuButton>
            <MenuList
              bg={useColorModeValue("white", "gray.700")}
              borderColor={useColorModeValue("gray.200", "gray.900")}
            >
              <MenuItem>Profile</MenuItem>
              <MenuItem>Settings</MenuItem>
              <MenuItem>Billing</MenuItem>
              <MenuDivider />
              <MenuItem>Sign out</MenuItem>
            </MenuList>
          </Menu>
        </Flex>
      </HStack>
    </Flex>
  );
};
