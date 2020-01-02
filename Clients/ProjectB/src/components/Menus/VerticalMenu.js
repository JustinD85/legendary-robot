import React, { useState } from "react"
import { Menu } from "semantic-ui-react"

export default ({ menuItems }) => {
  const [activeItemName, setActiveItemName] = useState()
  return (
    <Menu vertical>
      {createMenuItems(menuItems, activeItemName, setActiveItemName)}
    </Menu>
  )
}

const createMenuItems = ([{ header, names }, ...rest], active, func) => {
  const handleClick = ({ target: { id } }) => func(id)

  return (
    <>
      <Menu.Item>
        {<Menu.Header>{header}</Menu.Header>}
        {names.map(i => (
          <Menu.Item
            key={header + i}
            name={i}
            id={header + i}
            active={active === header + i}
            onClick={handleClick}
          />
        ))}
      </Menu.Item>
      {!!rest.length && createMenuItems(rest, active, func)}
    </>
  )
}
