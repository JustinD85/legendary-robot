import React from "react"
import { render } from "@testing-library/react"
import App from "./App"

test("renders company header", () => {
  const { getByText } = render(<App />)
  const linkElement = getByText(/Welcome to Madfunctional LLC/i)
  expect(linkElement).toBeInTheDocument()
})
