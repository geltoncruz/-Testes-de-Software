# Teste Unitário com xunit
## Projeto conta bancária
### Arquitetura dos sitema
```
| conta-projeto-test/
--| Conta/
---| Cliente.cs
---| Conta.cs
---| GerenciadoraConta.cs
---| GerenciadoraCliente.cs
--| ContaTest/
```
* Acesse o diretório **conta** e crie um new project console.
```js
$: cd conta/
$: dotnet new console
```
* Acesse diretório **contaTest** e crie um new xunit project
```js
$: cd ../contaTest
$: dotnet new xunit
```
* Agora adicione ao **Xunit** a reference o projeto que iremos testar.

```shell
 $: dotnet add reference ../conta/conta.csproj
```
* Ou adicione manualmente dentro do seu arquivo **ContaTest.csproj** 
```xml
<ItemGroup>
    <ProjectReference Include="..\conta\conta.csproj" />
 </ItemGroup>

```