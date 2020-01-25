import React from "react"
import Pawn from "../../components/Pawn/PawnDetail"
import { IPawn } from "../../models"
import { Segment } from "semantic-ui-react"

interface IProps {
  pawn: IPawn | null
  handleEdit: (setEditMode: boolean) => void
  handleCancel: () => void
}

//TODO: Until store implemented, will use props
export default ({ handleEdit, pawn, handleCancel }: IProps) => {
  return !!pawn ? (
    <Pawn pawn={pawn} handleEdit={handleEdit} handleCancel={handleCancel} />
  ) : (
    <Segment textAlign='center'>Select Card</Segment>
  )
}
