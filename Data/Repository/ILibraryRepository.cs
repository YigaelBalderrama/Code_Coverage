﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using SimpsonApp.Models;
using SimpsonApp.Data.Entities;
using Microsoft.AspNetCore.Mvc;

namespace SimpsonApp.Data.Repository
{
    public interface ILibraryRepository
    {
        Task<IEnumerable<CharacterEntity>> GetCharactersAsync(string orderBy, bool showPrase);
        Task<CharacterEntity> GetCharacterAsync(int charId, bool showPhrases = false);
        bool UpdateCharacter(CharacterEntity charac);
        void CreateCharacter(CharacterEntity character);
        Task<bool> DeleteCharacterAsync(int characId);

        Task<bool> SaveChangesAsync();
        ///FRASES
        Task<IEnumerable<PhraseEntity>> GetPhrasesAsync(int charID);
        Task<PhraseEntity>GetPhraseAsync(int PharaseId);
        Task<bool> UpdatePhraseAsync(PhraseEntity frase);
        void CreatePhrase(PhraseEntity frase);
        bool DeletePhrase(int PhraseID);
        
    }
}