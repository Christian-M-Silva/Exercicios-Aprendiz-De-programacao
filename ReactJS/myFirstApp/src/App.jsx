import { Fragment, useEffect, useState } from "react"

export function App() {
   const[task, setTask] = useState('')
   const[tasks, setTasks] = useState([])

   function addTask(event) {
      event.preventDefault()
      setTasks([...tasks, task])
      setTask("")
   }

   function reset() {
      setTasks([])
   }

   useEffect(()=>{
      const storage = localStorage.getItem("tarefas")

      if (storage) {
         setTasks(JSON.parse(storage))
      }
   }, [])

   useEffect(()=>{
      localStorage.setItem("tarefas", JSON.stringify(tasks))
   }, [tasks])

   return(
    <Fragment>
      <form onSubmit={addTask}>
         <label for="task">Tarefa</label><br/>
         <input type="text" name="task" id="task" placeholder="Escreva uma tarefa" value={task} onChange={event => setTask(event.target.value)} /><br/><br/>

         <button type="submit">Registrar tarefa</button><br/><br/>

         <button type="reset" onClick={reset}>Apagar as tarefas</button>
      </form>

      <ul id="areaTask">
         {
            tasks.map(item => (
               <li key={item}>{item}</li>
            ))
         }
      </ul>
    </Fragment>
   )
}