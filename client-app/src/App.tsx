import { useEffect, useState } from 'react'
import './App.css'
import axios from 'axios'
import { Header, List } from 'semantic-ui-react'

function App() {
  const [activities, setActivities] = useState([])
  useEffect(() => {
    axios.get('http://localhost:5000/api/activities')
    .then(res => {
      setActivities(res.data)
      console.log(res.data)
    })
    .catch(err => console.log(err))
  }, [])
  return (
    <div>
      <Header as='h2' icon='users' content='Reactivities' />
      <List>
        {activities.map((activity: any) => (
          <List.Item key={activity.id}>
            {activity.title}
          </List.Item>
          ))}
      </List>
    </div>
  )
}

export default App
