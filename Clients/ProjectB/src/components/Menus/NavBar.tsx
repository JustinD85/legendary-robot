import React from "react"
import { Menu } from "semantic-ui-react"

export default () => (
  <Menu inverted>
    <Menu.Item name='home' active={false} />
    <Menu.Item name='messages' active={true} />
    <Menu.Item name='friends' active={false} />
  </Menu>
)
