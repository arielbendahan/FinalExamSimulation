<template>
    <div >
      <h1>Welcome to the Task Manager</h1>
      <p>Manage your tasks efficiently.</p>
      <router-link to="/tasks">View Tasks</router-link>
      <br>
      <router-link to="/tasks/create">Create Task</router-link>
    </div>
  </template>
  
  <script>
  export default {
    name: 'Home',
  };
  </script>