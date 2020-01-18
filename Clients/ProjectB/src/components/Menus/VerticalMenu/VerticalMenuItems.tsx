import React, { ReactNode } from "react"
import { Menu } from "semantic-ui-react"

interface IProps {
  menuItems: {
    header: string
    onClickHandler: () => void
    names: string[]
  }[]
  activeItemName: string | null
  setActiveItemName: (id: string) => void
}

export const VerticalMenuItems: React.FC<IProps> = ({
  menuItems,
  activeItemName,
  setActiveItemName
}) => {
  const [{ header, names }, ...rest] = menuItems

  return (
    <>
      <Menu.Item>
        {<Menu.Header>{header}</Menu.Header>}
        {names.map(i => (
          <Menu.Item
            key={header + i}
            name={i}
            id={header + i}
            active={activeItemName === header + i}
            onClick={() => setActiveItemName(header + i)}
          />
        ))}
      </Menu.Item>

      {!!rest.length && (
        <VerticalMenuItems
          menuItems={rest}
          activeItemName={activeItemName}
          setActiveItemName={setActiveItemName}
        />
      )}
    </>
  )
}
