import React, { useState } from "react"
import { Menu } from "semantic-ui-react"
import { VerticalMenuItems } from "./VerticalMenuItems"

interface IProps {
  menuItems: {
    header: string
    onClickHandler: () => void
    names: string[]
  }[]
}

export default ({ menuItems }: IProps) => {
  const [activeItemName, setActiveItemName] = useState<string | null>(null)
  return (
    <Menu vertical>
      <VerticalMenuItems
        menuItems={menuItems}
        activeItemName={activeItemName}
        setActiveItemName={setActiveItemName}
      />
    </Menu>
  )
}
