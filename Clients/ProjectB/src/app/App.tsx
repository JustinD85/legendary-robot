import React from "react"
import "./App.css"
import PawnEditor from "../pages/templates/TEditor"
import Navigation from "../pages/templates/TNavigation"

//Apps purpose is to track where you are in the Application
//It should have no knowledge past Pages

//TODO: Implement Layouts
//TODO: Implement Templates
//TODO: Implement Pages
//TODO: Implement Styling only under Pages
//TODO: Implement Mobx
//TODO: Implement Routing

const App: React.FC = () => (
  <>
    <Navigation />
    <PawnEditor />
  </>
)

export default App
