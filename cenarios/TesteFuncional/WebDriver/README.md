# Selemium WebDrive
* Criado por engenheiro do google
* De javascripit para metodos nativos do browser e SO
* Maior estabilidade
* Especificação da W3C com apoio da openSource WebDrive para que os browser sejam responsáveis pela interação.


# Ambiente:
1. [Download do eclipse](http://www.eclipse.org/downloads/eclipse-packages/)

2. [Drive do firefox GeckoDrive](https://github.com/mozilla/geckodriver/releases)

3. Adicionar variáveis de ambiente
4. Abrir o Eclipse e criar projeto Marvin
5. Configurar marvin para receber pacote selenium e suas dependencias
6. Editar e adicionar ao `pom.xml` 
    [Denpendencia](https://mvnrepository.com/artifact/org.seleniumhq.selenium/selenium-java/3.7.1)
7. ```xml
    <dependencies>
  	<!-- https://mvnrepository.com/artifact/org.seleniumhq.selenium/selenium-java -->
	<dependency>
	    <groupId>org.seleniumhq.selenium</groupId>
	    <artifactId>selenium-java</artifactId>
	    <version>3.7.1</version>
</dependency>
    ```
7. Remover testes do buildPath
9. Atualizar a jre em library para a do workspace.	



# Primeira execução

```java

package testeFuncional;

import org.openqa.selenium.WebDriver;
import org.openqa.selenium.firefox.FirefoxDriver;

public class TesteSenai {
	public static void main(String[] args) {
		WebDriver driver = new FirefoxDriver();
	}
	
}

```