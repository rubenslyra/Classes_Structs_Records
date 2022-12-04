## Instruções  de Inicialização e Encerramento de Branchs
 
- git flow init 
        - main
        Branch name for production releases: [main]
        Branch name for "next release" development: [develop]

- git flow feature start GerenciamentoMemoria_01

- git flow feature finish GerenciamentoMemoria_01

### Starting a release branch :
- git flow release start 0.1.0

#### Finishing a release branch :
- git flow release finish ‘0.1.0’

### Tags - Versionamento

- git checkout tags/0.1.0
- git tag -a 0.1.0 -m "Versão 0.1.0"
- git push origin 0.1.0

- git push --tags