import React from "react"
import VerticalMenu from "../../components/Menus/VerticalMenu"

export default () => <VerticalMenu menuItems={menuItems} />

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
]
