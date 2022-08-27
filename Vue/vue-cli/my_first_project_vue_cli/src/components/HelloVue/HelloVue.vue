<template>
  <div>
    <h1>
      {{ msg }}
    </h1>

    <input type="text" placeholder="Digite seu nome" v-model="name" />
    <section v-show="name">
      <p>Seu nome é : {{ name }}?</p>

      <button @click.prevent="alerta()">Sim</button>
    </section>
  </div>
</template>

<script src="./HelloVue.js"></script>
<style src="./HelloVue.css"></style>