import { createRouter, createWebHistory } from 'vue-router';
import Home from '@/views/Home.vue';
import TaskList from '@/views/TaskList.vue';
import CreateTask from '@/views/CreateTask.vue';

const routes = [
  { path: '/', name: 'Home', component: Home },
  { path: '/tasks', name: 'Tasks', component: TaskList },
  { path: '/tasks/create', name: 'CreateTask', component: CreateTask },
];

const router = createRouter({
  history: createWebHistory(import.meta.env.BASE_URL),
  routes,
});

export default router;