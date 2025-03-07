import { ChakraProvider } from '@chakra-ui/react';
import { theme } from './theme';
import { Spinner } from '@chakra-ui/react'

const chakraProvider = new ChakraProvider(theme);

export { chakraProvider, Spinner };