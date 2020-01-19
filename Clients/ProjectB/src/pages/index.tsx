import React from "react"
import ContentEditor from "./templates/Editor2Col"
import Menu from "../containers/Menus/VerticalWithHeaderContainer"
import Pawn from "../containers/Lists/Pawn/PawnContainer"

export const PawnEditor = () => <ContentEditor Col1={Menu} Col2={Pawn} />
