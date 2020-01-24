import React, { useState } from "react"
import { Menu } from "semantic-ui-react"
import MenuItems from "../../components/Menus/MenuItems"

const menuItems = [
  {
    header: "Create",
    onClickHandler: () => alert("Create"),
    names: ["Some", "One"]
  },
  {
    header: "Read",
    onClickHandler: () => alert("Read"),
    names: ["All", "Pawn", "Item"]
  },
  {
    header: "Update",
    onClickHandler: () => alert("Update"),
    names: ["Pawn", "Item"]
  },
  {
    header: "Delete",
    onClickHandler: () => alert("Delete"),
    names: ["by ID"]
  }
] // will be gotten from datastore in future

export default () => {
  const [activeItemName, setActiveItemName] = useState<string | null>(null)
  return (
    <Menu vertical>
      <MenuItems
        menuItems={menuItems}
        activeItemName={activeItemName}
        setActiveItemName={setActiveItemName}
      />
    </Menu>
  )
}
