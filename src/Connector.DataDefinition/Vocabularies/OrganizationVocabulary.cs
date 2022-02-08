using CluedIn.Core.Data;
using CluedIn.Core.Data.Vocabularies;

namespace CluedIn.Connector.DataDefinition.Vocabularies
{
    public class  OrganizationVocabulary : SimpleVocabulary
    {
        public OrganizationVocabulary()
        {
            VocabularyName = "Chad Organization"; 
            KeyPrefix      = "chad.organization"; 
            KeySeparator   = ".";
            Grouping       = EntityType.Organization; // TODO: Make sure EntityType is correct.

            //TODO: Make sure that any properties mapped into CluedIn Vocabulary are not in the group.
            AddGroup("Chad Organization Details", group =>
            {
                Id = group.Add(new VocabularyKey("Id", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                Name = group.Add(new VocabularyKey("Name", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                Status = group.Add(new VocabularyKey("Status", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                Location = group.Add(new VocabularyKey("Location", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                
            });

            //TODO: If the property is already set in the clueproducer, it doesn't have to be here.
             
            //TODO: Don't forget to map all possible properties into already existing CluedIn Vocabularies.
        
        }

        public VocabularyKey Id { get; private set; }
        
        public VocabularyKey Name { get; private set; }
        
        public VocabularyKey Status { get; private set; }
        
        public VocabularyKey Location { get; private set; }
    }
}
