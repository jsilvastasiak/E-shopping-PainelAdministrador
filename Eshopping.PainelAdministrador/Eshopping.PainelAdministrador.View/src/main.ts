import Vue from 'vue';
import App from './App.vue';
import VueHead from 'vue-head';
import { IApiClient, ApiClient } from './infraestrutura/apiClient';

Vue.config.productionTip = true;
Vue.use(VueHead);

const apiClient = new ApiClient({
    baseUrl: "https://localhost:44370/api",
    diretorioImagens: "https://cs2496c7b05ef5fx4459xb88.file.core.windows.net/eshopping",
    sas: "sv=2019-10-10&ss=f&srt=so&sp=r&se=2030-12-08T01:55:22Z&st=2020-06-07T17:55:20Z&spr=https&sig=2wXkaOVYZuupXS3H65kp8kg9bWFyRxTQFbghEXsgSGk%3D",
    token: "eyJhbGciOiJIUzI1NiIsInR5cCI6IkpXVCJ9.eyJ1bmlxdWVfbmFtZSI6Ik1hcmxlaSIsInByb3BpZXRhcmlvIjoiMyIsImxvamEiOiIxIiwibmJmIjoxNjE1NzU1NzE5LCJleHAiOjE2MTYzNjA1MTksImlhdCI6MTYxNTc1NTcxOX0.iDCfh0cjp4cObANXO_rATzodHq6xwiSdUkAHc3mQCT8"
}) as IApiClient;

new Vue({
    provide: {
        api: apiClient,
        usuarioLogado: null,
    },
    render: h => h(App)
}).$mount('#app');
