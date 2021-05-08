using Atlantic.MasterData.Data.Context;
using Atlantic.MasterData.Domain.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;

namespace Atlantic.MasterData.Data.DataSeed {
    public class SeedMasterData {

        public static async Task SeedData(MasterDataContext masterDataContext) {

            if (await masterDataContext.Countries.AnyAsync()) return;
            if (await masterDataContext.States.AnyAsync()) return;
            if (await masterDataContext.Cities.AnyAsync()) return;
            var countriesJsonData = await System.IO.File.ReadAllTextAsync("Data/countries.json");
            var countries = JsonSerializer.Deserialize<List<Tempcountries>>(countriesJsonData);

            var statesJsonData = await System.IO.File.ReadAllTextAsync("Data/states.json");
            var states = JsonSerializer.Deserialize<List<Tempstates>>(statesJsonData);

            var CityJsonData = await System.IO.File.ReadAllTextAsync("Data/cities.json");
            var cities = JsonSerializer.Deserialize<List<Tempcities>>(CityJsonData);

            foreach (var country in countries) {
                masterDataContext.Countries.Add(new Countries() {
                    Name = country.name,
                    ISO3 = country.iso3,
                    ISO2 = country.iso2,
                    Phonecode = country.phonecode,
                    Capital = country.capital,
                    Currency = country.currency,
                    Currency_symbol = country.currency_symbol,
                    TLD = country.tld,
                    Native = country.native,
                    Region = country.region,
                    Subregion = country.subregion,
                    Timezones = JsonSerializer.Serialize(country.timezones),
                    Translations = JsonSerializer.Serialize(country.translations),
                    Latitude = Convert.ToDecimal(country.latitude),
                    Longitude = Convert.ToDecimal(country.longitude),
                    Emoji = country.emoji,
                    EmojiU = country.emojiU,
                    CreatedDate = Convert.ToDateTime(country.created_at),
                    UpdatedDate = Convert.ToDateTime(country.updated_at),
                    Flag = country.flag,
                    WikiDataId = country.wikiDataId,
                    //States = getStatesByCountryCode(country.iso3)
                }); 
            }
           
            foreach (var state in states) {
                masterDataContext.States.Add(new States() {
                    Name = state.name,
                    ISO2 = state.iso2,
                    CountryCode = state.country_code,
                    CountriesId = state.country_id,
                    FipsCode = state.fips_code,
                    Latitude = Convert.ToDecimal(state.latitude),
                    Longitude = Convert.ToDecimal(state.longitude),
                    CreatedDate = Convert.ToDateTime(state.created_at),
                    UpdatedDate = Convert.ToDateTime(state.updated_at),
                    Flag = state.flag,
                    WikiDataId = state.wikiDataId,
                });
            }
            
            foreach (var city in cities) {
                masterDataContext.Cities.Add(new Cities() {
                    Name = city.name,
                    CountryCode = city.country_code,
                    CountriesId = city.country_id,
                    StateCode = city.state_code,
                    StatesId = city.state_id,
                    Latitude = Convert.ToDecimal(city.latitude),
                    Longitude = Convert.ToDecimal(city.longitude),
                    CreatedDate = Convert.ToDateTime(city.created_at),
                    UpdatedDate = Convert.ToDateTime(city.updated_at),
                    Flag = city.flag,
                    WikiDataId = city.wikiDataId,
                });
            }
           
            await masterDataContext.SaveChangesAsync();


        }
        #region Coutries Temp Models
        public class Tempcountries {
            public int id { get; set; }
            public string name { get; set; }
            public string iso3 { get; set; }
            public string iso2 { get; set; }
            public string phonecode { get; set; }
            public string capital { get; set; }
            public string currency { get; set; }
            public string currency_symbol { get; set; }
            public string tld { get; set; }
            public string native { get; set; }
            public string region { get; set; }
            public string subregion { get; set; }
            public IList<TimeZone> timezones { get; set; }
            public Translations translations { get; set; }
            public string latitude { get; set; }
            public string longitude { get; set; }
            public string emoji { get; set; }
            public string emojiU { get; set; }
            public string created_at { get; set; }
            public string updated_at { get; set; }
            public short flag { get; set; }
            public string wikiDataId { get; set; }
        }
        public class Translations {
            public string br { get; set; }
            public string pt { get; set; }
            public string nl { get; set; }
            public string hr { get; set; }
            public string fa { get; set; }
            public string de { get; set; }
            public string es { get; set; }
            public string fr { get; set; }
            public string ja { get; set; }
            public string it { get; set; }
        }
        public class TimeZone {
            public string zoneName { get; set; }
            public int gmtOffset { get; set; }
            public string gmtOffsetName { get; set; }
            public string abbreviation { get; set; }
            public string tzName { get; set; }

        }
        #endregion

        #region States Temp Models
        public class Tempstates {
            public int id { get; set; }
            public string name { get; set; }
            public int country_id { get; set; }
            public string iso2 { get; set; }
            public string country_code { get; set; }
            public string fips_code { get; set; }
            public string latitude { get; set; }
            public string longitude { get; set; }
            public string created_at { get; set; }
            public string updated_at { get; set; }
            public short flag { get; set; }
            public string wikiDataId { get; set; }
        }
        #endregion

        #region Cities Temp Models
        public class Tempcities {
            public int id { get; set; }
            public string name { get; set; }
            public int state_id { get; set; }
            public string state_code { get; set; }
            public int country_id { get; set; }
            public string country_code { get; set; }
            public string latitude { get; set; }
            public string longitude { get; set; }
            public string created_at { get; set; }
            public string updated_at { get; set; }
            public short flag { get; set; }
            public string wikiDataId { get; set; }
        }
        #endregion
    }
}
