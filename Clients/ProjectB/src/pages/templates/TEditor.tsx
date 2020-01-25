import React, { useState } from "react"
import { Grid, Header, Segment } from "semantic-ui-react"
import Menu from "../../containers/Menus/MenuItemsContainer"
import Pawns from "../../containers/Pawn/PawnListContainer"
import PawnDetail from "../../containers/Pawn/PawnDetailContainer"
import EditPawn from "../../components/Pawn/EditPawn"
import { IPawn } from "../../models"

//make the non-grid components here input and implement a page incorporating this template once complete
//TODO: Until implement store, have state here. Pass down props(undesirable for long-term)
export default () => {
  const [pawn, setPawn] = useState<IPawn | null>(null)
  const [isEditMode, setIsEditMode] = useState(false)

  function handleSetPawn(pawn: IPawn) {
    setIsEditMode(false)
    setPawn(pawn)
  }

  return (
    <>
      <Header textAlign='center' size='large'>
        Welcome to the Content Editor
      </Header>
      <Grid celled>
        <Grid.Column width={2}>
          <Menu />
        </Grid.Column>
        <Grid.Column width={10}>
          <Pawns handleSelectPawn={handleSetPawn} />
        </Grid.Column>
        <Grid.Column width={4}>
          {!pawn ? (
            <Segment>Select a Pawn</Segment>
          ) : !isEditMode ? (
            <PawnDetail
              pawn={pawn}
              handleCancel={() => setPawn(null)}
              handleEdit={setIsEditMode}
            />
          ) : (
            <EditPawn
              pawn={pawn}
              handleSubmit={handleSetPawn}
              handleCancel={() => setIsEditMode(false)}
            />
          )}
        </Grid.Column>
      </Grid>
    </>
  )
}
