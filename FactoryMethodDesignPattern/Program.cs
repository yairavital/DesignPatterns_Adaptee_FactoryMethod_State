using FactoryMethodDesignPattern;
using System.Text.Json;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

EmojyCreatorcs surprised = new SurprisedCreator(2);
Emojy surprsedEmojy = surprised.CreatEmojy(5);

var d = JsonSerializer.Serialize(surprsedEmojy);
Console.WriteLine(d) ;