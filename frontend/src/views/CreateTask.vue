<template>
    <div>
      <h1>Create Task</h1>
      <form @submit.prevent="createTask">
        <input v-model="newTask.title" placeholder="Task Title" required />
        <textarea v-model="newTask.description" placeholder="Task Description"></textarea>
        <br>
        <button type="submit">Create Task</button>
      </form>
      <br>
      <router-link to="/tasks">Back to Tasks</router-link>
    </div>
  </template>
  
  <script>
  import axios from 'axios';
  
  export default {
    data() {
      return {
        newTask: {
          title: '',
          description: '',
          completed: false,
        },
      };
    },
    methods: {
      async createTask() {
        await axios.post(`${import.meta.env.VITE_API_URL}/api/tasks`, this.newTask);
        this.$router.push('/tasks');
      },
    },
  };
  </script>