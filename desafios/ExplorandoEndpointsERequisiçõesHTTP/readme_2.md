# 🔐 Validador de Token de Acesso

## 💼 Descrição
Na consultoria onde você atua, foi necessário criar uma **camada de autenticação simples** para simular uma API que apenas aceita **requisições autenticadas**.  

Sua missão é escrever um programa que **valide um token de acesso** conforme regras específicas.

---

## 📥 Entrada
O programa deve receber uma **string** representando o **token de acesso**.

Para que o token seja considerado **válido**, ele deve atender a todos os seguintes critérios:

1. Ter **exatamente 10 caracteres**  
2. **Começar com a letra "A" maiúscula**  
3. Conter **pelo menos um dígito numérico**

---

## 📤 Saída
O programa deverá validar o token e exibir:

- `Acesso permitido` → caso o token seja válido  
- `Acesso negado` → caso o token não seja válido  

---

## 🧩 Exemplos

A tabela abaixo apresenta exemplos com alguns dados de entrada e suas respectivas saídas esperadas.  
Certifique-se de testar seu programa com esses exemplos e com outros casos possíveis.

| **Entrada** | **Saída** |
|:--|:--|
| A123456789 | Acesso permitido |
| B123456789 | Acesso negado |
| A12345 | Acesso negado |
| Aabcdefghi | Acesso negado |

---

## ⚠️ Atenção
É **extremamente importante** que as **entradas e saídas** sejam **exatamente iguais** às descrições do desafio de código.

---

## 🧠 Conceitos Envolvidos
- Validação de strings  
- Expressões condicionais (`if`, `elif`, `else`)  
- Contagem e verificação de caracteres  
- Autenticação simulada  

---

## 🛠️ Tecnologias sugeridas
- **Linguagem:** Python, JavaScript, ou Java  
- **Paradigma:** Programação Estruturada  

---

### 👩‍💻 Autora
Desenvolvido por **Alice Maria Sena (Sena)** 🔒  
💼 [LinkedIn](https://www.linkedin.com/in/alicessenapereira/)
