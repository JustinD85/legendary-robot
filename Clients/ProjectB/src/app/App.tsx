import React from "react"
import "./App.css"
import { Grid } from "semantic-ui-react"
import VerticalMenuContainer from "../containers/Menus/VerticalWithHeaderContainer"
import PawnContainer from "../containers/Lists/Pawn/PawnContainer"

//Apps purpose is to track where you are in the Application
//It should have no knowledge past Pages

//TODO: Implement Layouts
//TODO: Implement Templates
//TODO: Implement Pages

const App: React.FC = () => {
  return (
    <Grid celled>
      <Grid.Column width={3}>
        <VerticalMenuContainer />
      </Grid.Column>
      <Grid.Column width={13}>
        <PawnContainer />
      </Grid.Column>
    </Grid>
  )
}
export default App
