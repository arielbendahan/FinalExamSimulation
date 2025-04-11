<template>
    <div>
      <h1>Tasks</h1>
      <router-link to="/tasks/create">Create New Task</router-link>
      <br>
      <router-link to="/">Back to Home</router-link>
      <ul>
        <li v-for="task in tasks" :key="task.id">
            <span :class="{ completed: task.completed }">{{ task.title }}: {{ task.description }}</span>
            <div class="button-group">
                <button @click="toggleComplete(task)">Toggle Complete</button>
                <button @click="editTask(task)">Edit</button>
                <button @click="deleteTask(task.id)">Delete</button>
            </div>
        </li>
      </ul>
      <div v-if="editingTask">
        <h2>Edit Task</h2>
        <form @submit.prevent="updateTask">
          <input v-model="editingTask.title" placeholder="Task Title" required />
          <textarea v-model="editingTask.description" placeholder="Task Description"></textarea>
          <button type="submit">Update Task</button>
          <button @click="cancelEdit">Cancel</button>
        </form>
      </div>
    </div>
  </template>
  
  <script>
  import axios from 'axios';
  
  export default {
    data() {
      return {
        tasks: [],
        editingTask: null,
      };
    },
    async created() {
      await this.fetchTasks();
    },
    methods: {
      async fetchTasks() {
        const response = await axios.get(`${import.meta.env.VITE_API_URL}/api/tasks`);
        this.tasks = response.data;
      },
      async deleteTask(id) {
        await axios.delete(`${import.meta.env.VITE_API_URL}/api/tasks/${id}`);
        this.tasks = this.tasks.filter(task => task.id !== id);
      },
      editTask(task) {
        this.editingTask = { ...task };
      },
      async updateTask() {
        await axios.put(`${import.meta.env.VITE_API_URL}/api/tasks/${this.editingTask.id}`, this.editingTask);
        this.editingTask = null;
        await this.fetchTasks();
      },
      cancelEdit() {
        this.editingTask = null;
      },
      async toggleComplete(task) {
        const updatedTask = { ...task, completed: !task.completed };
        await axios.put(`${import.meta.env.VITE_API_URL}/api/tasks/${task.id}`, updatedTask);
        task.completed = !task.completed;
      },
    },
  };
  </script>
  
  <style>
  .completed {
    text-decoration: line-through;
  }
  .button-group button {
  margin-right: 10px;
}

.button-group button:last-child {
  margin-right: 0;
}
  </style>