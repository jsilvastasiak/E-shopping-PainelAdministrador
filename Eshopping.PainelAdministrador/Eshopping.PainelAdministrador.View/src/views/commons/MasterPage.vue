<template>
    <div>
        <AppHead></AppHead>
        <Navegacao />
        <MenuPrincipal />
    </div>
</template>

<script lang="ts">
    import { Component, Prop, Vue } from 'vue-property-decorator';

    @Component
    export default class MasterPage extends Vue {
    }
</script>

<style scoped>
</style>