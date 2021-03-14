<template>
    <div id="app">
        <MasterPage>
        </MasterPage>
    </div>
</template>

<script lang="ts">
    import { Component, Vue } from 'vue-property-decorator';
    import MasterPage from './views/commons/MasterPage.vue';

    @Component({
        components: {
            MasterPage
        }
    })
    export default class App extends Vue {
    }
</script>

<style>
</style>
