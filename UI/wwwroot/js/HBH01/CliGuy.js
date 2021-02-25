import DemoCLI from "./cli.js"

export const CLI_Guy = (() => {

  class CLI_Guy {
    constructor(params) {    
      this._params = params;
      this._cli = new DemoCLI("#cliContainer");    
      this.InitComponent();
      this.Breathe();  
    }
  
    InitComponent() {
     // this._LoadUI();
     
      if (this._cli) {
       // this._inputCli = new StInput(this._cli.container)
        const h = (async () => {
          this._cli.printPrompt()
          await this._cli.type('echo "Creating Terminal"')
     
        })()

      }}
    
      Breathe(){
      const h = (async () => {
        this._cli.printPrompt()
        await this._cli.type('it Feels wonderful to be alive !')

      })()
      
    }

    Breathe2 = function(){
      const h = (async () => {
        this._cli.println();

        this._cli.printPrompt()
        await this._cli.type('and another independent function serti ')
        this._cli.printCursor();

      })()
      }

   


  };
 
  return {
    CLI_Guy: CLI_Guy,
  };

})();