export default{
    name: 'HelloVue',

    data(){
        return{
            msg: "Hello Vue!!!",
            name: "",
        }
    },
    methods:{
        alerta(){
            alert(`Olá ${this.name} seja bem-vindo!!!`)
        }
    }
}