using CluedIn.Core.Data;
using CluedIn.Core.Data.Vocabularies;

namespace CluedIn.Connector.DataDefinition.Vocabularies
{
    public class  PersonVocabulary : SimpleVocabulary
    {
        public  PersonVocabulary()
        {
            VocabularyName = "Chad Person"; 
            KeyPrefix      = "chad.person"; 
            KeySeparator   = ".";
            Grouping       = EntityType.Person; // TODO: Make sure EntityType is correct.

            //TODO: Make sure that any properties mapped into CluedIn Vocabulary are not in the group.
            AddGroup("Chad Person Details", group =>
            {
                GCI = group.Add(new VocabularyKey("GCI", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                Id = group.Add(new VocabularyKey("Id", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                FirstName = group.Add(new VocabularyKey("FirstName", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                MiddleName = group.Add(new VocabularyKey("MiddleName", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                LastName = group.Add(new VocabularyKey("LastName", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                OrganizationId = group.Add(new VocabularyKey("OrganizationId", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
            });

            //TODO: If the property is already set in the clueproducer, it doesn't have to be here.
             
            //TODO: Don't forget to map all possible properties into already existing CluedIn Vocabularies.
        
        }

        public VocabularyKey GCI { get; private set; }
        public VocabularyKey Id { get; private set; }
        
        public VocabularyKey FirstName { get; private set; }
        
        public VocabularyKey MiddleName { get; private set; }
        
        public VocabularyKey LastName { get; private set; }
        public VocabularyKey OrganizationId { get; private set; }
    }
}
