import React from "react"
import { Grid } from "semantic-ui-react"
import Menu from "../../containers/Menus/MenuItemsContainer"
import Pawn from "../../containers/Pawn/PawnListContainer"
import PawnDetail from "../../containers/Pawn/PawnDetailContainer"
import EditPawn from "../../components/Pawn/EditPawn"

//make the non-grid components here input and implement a page incorporating this template once complete
export default () => (
  <>
    <h1>Welcome to the Content Editor</h1>
    <Grid celled>
      <Grid.Column width={2}>
        <Menu />
      </Grid.Column>
      <Grid.Column width={10}>
        <Pawn />
      </Grid.Column>
      <Grid.Column width={4}>
        <PawnDetail />
        <EditPawn />
      </Grid.Column>
    </Grid>
  </>
)
