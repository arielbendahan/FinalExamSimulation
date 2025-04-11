<template>
  <div>
    <nav>
      <router-link to="/">Home</router-link>
      <router-link to="/tasks">Tasks</router-link>
      <router-link to="/tasks/create">Create Task</router-link>
    </nav>
    <router-view />
  </div>
</template>

<script>
export default {
  name: 'PrivateLayout',
};
</script>