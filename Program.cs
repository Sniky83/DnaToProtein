using System;
using System.Text;
using System.Collections.Generic;

public class Program
{
	public static void Main()
	{
		string rna_messenger, rna_translation, orf1ab_polyproteinV1, orf1ab_polyprotein, orf1ab_polyproteinV2, surface_glycoprotein, ORF3a_protein, envelope_protein, membrane_glycoprotein, ORF6_protein, ORF7a_protein, ORF8_protein, nucleocapsid_phosphoprotein, ORF10_protein;
		rna_messenger = new String(TranscriptDNA().ToArray());
		rna_translation = new String(Rna_Translation(rna_messenger).ToArray());
		orf1ab_polyproteinV1 = new String(RnaToAminoAcid(rna_translation, 265, 13471).ToArray());
		orf1ab_polyproteinV2 = new String(RnaToAminoAcid(rna_translation, 13467, 21555).ToArray());
		orf1ab_polyprotein = orf1ab_polyproteinV1 + orf1ab_polyproteinV2;
		surface_glycoprotein = new String(RnaToAminoAcid(rna_translation, 21562, 25384).ToArray());
		ORF3a_protein = new String(RnaToAminoAcid(rna_translation, 25392, 26220).ToArray());
		envelope_protein = new String(RnaToAminoAcid(rna_translation, 26244, 26472).ToArray());
		membrane_glycoprotein = new String(RnaToAminoAcid(rna_translation, 26522, 27191).ToArray());
		ORF6_protein = new String(RnaToAminoAcid(rna_translation, 27201, 27387).ToArray());
		ORF7a_protein = new String(RnaToAminoAcid(rna_translation, 27393, 27759).ToArray());
		ORF8_protein = new String(RnaToAminoAcid(rna_translation, 27893, 28259).ToArray());
		nucleocapsid_phosphoprotein = new String(RnaToAminoAcid(rna_translation, 28273, 29533).ToArray());
		ORF10_protein = new String(RnaToAminoAcid(rna_translation, 29557, 29674).ToArray());
		Console.WriteLine("RNA MESSENGER :");
		Console.WriteLine(rna_messenger);
		Console.WriteLine("------------------------------------------------------------------------------------------------------------------");
		Console.WriteLine("RNA TRANSLATION :");
		Console.WriteLine(rna_translation);
		Console.WriteLine("------------------------------------------------------------------------------------------------------------------");
		Console.WriteLine("ORF1AB POLYPROTEIN :");
		Console.WriteLine(orf1ab_polyprotein);
		Console.WriteLine("------------------------------------------------------------------------------------------------------------------");
		Console.WriteLine("SURFACE GLYCOPROTEIN :");
		Console.WriteLine(surface_glycoprotein);
		Console.WriteLine("------------------------------------------------------------------------------------------------------------------");
		Console.WriteLine("ORF3A PROTEIN :");
		Console.WriteLine(ORF3a_protein);
		Console.WriteLine("------------------------------------------------------------------------------------------------------------------");
		Console.WriteLine("ENVELOPE PROTEIN :");
		Console.WriteLine(envelope_protein);
		Console.WriteLine("------------------------------------------------------------------------------------------------------------------");
		Console.WriteLine("MEMBRANE GLYCOPROTEIN :");
		Console.WriteLine(membrane_glycoprotein);
		Console.WriteLine("------------------------------------------------------------------------------------------------------------------");
		Console.WriteLine("ORF6 PROTEIN :");
		Console.WriteLine(ORF6_protein);
		Console.WriteLine("------------------------------------------------------------------------------------------------------------------");
		Console.WriteLine("ORF7A PROTEIN :");
		Console.WriteLine(ORF7a_protein);
		Console.WriteLine("------------------------------------------------------------------------------------------------------------------");
		Console.WriteLine("ORF8 PROTEIN :");
		Console.WriteLine(ORF8_protein);
		Console.WriteLine("------------------------------------------------------------------------------------------------------------------");
		Console.WriteLine("NUCLEOCAPSID PHOSPHOPROTEIN :");
		Console.WriteLine(nucleocapsid_phosphoprotein);
		Console.WriteLine("------------------------------------------------------------------------------------------------------------------");
		Console.WriteLine("ORF10 PROTEIN :");
		Console.WriteLine(ORF10_protein);
		Console.ReadKey();
	}

	public static List<char> TranscriptDNA()
	{
		string dna_covid19 = "attaaaggtttataccttcccaggtaacaaaccaaccaactttcgatctcttgtagatctgttctctaaacgaactttaaaatctgtgtggctgtcactcggctgcatgcttagtgcactcacgcagtataattaataactaattactgtcgttgacaggacacgagtaactcgtctatcttctgcaggctgcttacggtttcgtccgtgttgcagccgatcatcagcacatctaggtttcgtccgggtgtgaccgaaaggtaagatggagagccttgtccctggtttcaacgagaaaacacacgtccaactcagtttgcctgttttacaggttcgcgacgtgctcgtacgtggctttggagactccgtggaggaggtcttatcagaggcacgtcaacatcttaaagatggcacttgtggcttagtagaagttgaaaaaggcgttttgcctcaacttgaacagccctatgtgttcatcaaacgttcggatgctcgaactgcacctcatggtcatgttatggttgagctggtagcagaactcgaaggcattcagtacggtcgtagtggtgagacacttggtgtccttgtccctcatgtgggcgaaataccagtggcttaccgcaaggttcttcttcgtaagaacggtaataaaggagctggtggccatagttacggcgccgatctaaagtcatttgacttaggcgacgagcttggcactgatccttatgaagattttcaagaaaactggaacactaaacatagcagtggtgttacccgtgaactcatgcgtgagcttaacggaggggcatacactcgctatgtcgataacaacttctgtggccctgatggctaccctcttgagtgcattaaagaccttctagcacgtgctggtaaagcttcatgcactttgtccgaacaactggactttattgacactaagaggggtgtatactgctgccgtgaacatgagcatgaaattgcttggtacacggaacgttctgaaaagagctatgaattgcagacaccttttgaaattaaattggcaaagaaatttgacaccttcaatggggaatgtccaaattttgtatttcccttaaattccataatcaagactattcaaccaagggttgaaaagaaaaagcttgatggctttatgggtagaattcgatctgtctatccagttgcgtcaccaaatgaatgcaaccaaatgtgcctttcaactctcatgaagtgtgatcattgtggtgaaacttcatggcagacgggcgattttgttaaagccacttgcgaattttgtggcactgagaatttgactaaagaaggtgccactacttgtggttacttaccccaaaatgctgttgttaaaatttattgtccagcatgtcacaattcagaagtaggacctgagcatagtcttgccgaataccataatgaatctggcttgaaaaccattcttcgtaagggtggtcgcactattgcctttggaggctgtgtgttctcttatgttggttgccataacaagtgtgcctattgggttccacgtgctagcgctaacataggttgtaaccatacaggtgttgttggagaaggttccgaaggtcttaatgacaaccttcttgaaatactccaaaaagagaaagtcaacatcaatattgttggtgactttaaacttaatgaagagatcgccattattttggcatctttttctgcttccacaagtgcttttgtggaaactgtgaaaggtttggattataaagcattcaaacaaattgttgaatcctgtggtaattttaaagttacaaaaggaaaagctaaaaaaggtgcctggaatattggtgaacagaaatcaatactgagtcctctttatgcatttgcatcagaggctgctcgtgttgtacgatcaattttctcccgcactcttgaaactgctcaaaattctgtgcgtgttttacagaaggccgctataacaatactagatggaatttcacagtattcactgagactcattgatgctatgatgttcacatctgatttggctactaacaatctagttgtaatggcctacattacaggtggtgttgttcagttgacttcgcagtggctaactaacatctttggcactgtttatgaaaaactcaaacccgtccttgattggcttgaagagaagtttaaggaaggtgtagagtttcttagagacggttgggaaattgttaaatttatctcaacctgtgcttgtgaaattgtcggtggacaaattgtcacctgtgcaaaggaaattaaggagagtgttcagacattctttaagcttgtaaataaatttttggctttgtgtgctgactctatcattattggtggagctaaacttaaagccttgaatttaggtgaaacatttgtcacgcactcaaagggattgtacagaaagtgtgttaaatccagagaagaaactggcctactcatgcctctaaaagccccaaaagaaattatcttcttagagggagaaacacttcccacagaagtgttaacagaggaagttgtcttgaaaactggtgatttacaaccattagaacaacctactagtgaagctgttgaagctccattggttggtacaccagtttgtattaacgggcttatgttgctcgaaatcaaagacacagaaaagtactgtgcccttgcacctaatatgatggtaacaaacaataccttcacactcaaaggcggtgcaccaacaaaggttacttttggtgatgacactgtgatagaagtgcaaggttacaagagtgtgaatatcacttttgaacttgatgaaaggattgataaagtacttaatgagaagtgctctgcctatacagttgaactcggtacagaagtaaatgagttcgcctgtgttgtggcagatgctgtcataaaaactttgcaaccagtatctgaattacttacaccactgggcattgatttagatgagtggagtatggctacatactacttatttgatgagtctggtgagtttaaattggcttcacatatgtattgttctttctaccctccagatgaggatgaagaagaaggtgattgtgaagaagaagagtttgagccatcaactcaatatgagtatggtactgaagatgattaccaaggtaaacctttggaatttggtgccacttctgctgctcttcaacctgaagaagagcaagaagaagattggttagatgatgatagtcaacaaactgttggtcaacaagacggcagtgaggacaatcagacaactactattcaaacaattgttgaggttcaacctcaattagagatggaacttacaccagttgttcagactattgaagtgaatagttttagtggttatttaaaacttactgacaatgtatacattaaaaatgcagacattgtggaagaagctaaaaaggtaaaaccaacagtggttgttaatgcagccaatgtttaccttaaacatggaggaggtgttgcaggagccttaaataaggctactaacaatgccatgcaagttgaatctgatgattacatagctactaatggaccacttaaagtgggtggtagttgtgttttaagcggacacaatcttgctaaacactgtcttcatgttgtcggcccaaatgttaacaaaggtgaagacattcaacttcttaagagtgcttatgaaaattttaatcagcacgaagttctacttgcaccattattatcagctggtatttttggtgctgaccctatacattctttaagagtttgtgtagatactgttcgcacaaatgtctacttagctgtctttgataaaaatctctatgacaaacttgtttcaagctttttggaaatgaagagtgaaaagcaagttgaacaaaagatcgctgagattcctaaagaggaagttaagccatttataactgaaagtaaaccttcagttgaacagagaaaacaagatgataagaaaatcaaagcttgtgttgaagaagttacaacaactctggaagaaactaagttcctcacagaaaacttgttactttatattgacattaatggcaatcttcatccagattctgccactcttgttagtgacattgacatcactttcttaaagaaagatgctccatatatagtgggtgatgttgttcaagagggtgttttaactgctgtggttatacctactaaaaaggctggtggcactactgaaatgctagcgaaagctttgagaaaagtgccaacagacaattatataaccacttacccgggtcagggtttaaatggttacactgtagaggaggcaaagacagtgcttaaaaagtgtaaaagtgccttttacattctaccatctattatctctaatgagaagcaagaaattcttggaactgtttcttggaatttgcgagaaatgcttgcacatgcagaagaaacacgcaaattaatgcctgtctgtgtggaaactaaagccatagtttcaactatacagcgtaaatataagggtattaaaatacaagagggtgtggttgattatggtgctagattttacttttacaccagtaaaacaactgtagcgtcacttatcaacacacttaacgatctaaatgaaactcttgttacaatgccacttggctatgtaacacatggcttaaatttggaagaagctgctcggtatatgagatctctcaaagtgccagctacagtttctgtttcttcacctgatgctgttacagcgtataatggttatcttacttcttcttctaaaacacctgaagaacattttattgaaaccatctcacttgctggttcctataaagattggtcctattctggacaatctacacaactaggtatagaatttcttaagagaggtgataaaagtgtatattacactagtaatcctaccacattccacctagatggtgaagttatcacctttgacaatcttaagacacttctttctttgagagaagtgaggactattaaggtgtttacaacagtagacaacattaacctccacacgcaagttgtggacatgtcaatgacatatggacaacagtttggtccaacttatttggatggagctgatgttactaaaataaaacctcataattcacatgaaggtaaaacattttatgttttacctaatgatgacactctacgtgttgaggcttttgagtactaccacacaactgatcctagttttctgggtaggtacatgtcagcattaaatcacactaaaaagtggaaatacccacaagttaatggtttaacttctattaaatgggcagataacaactgttatcttgccactgcattgttaacactccaacaaatagagttgaagtttaatccacctgctctacaagatgcttattacagagcaagggctggtgaagctgctaacttttgtgcacttatcttagcctactgtaataagacagtaggtgagttaggtgatgttagagaaacaatgagttacttgtttcaacatgccaatttagattcttgcaaaagagtcttgaacgtggtgtgtaaaacttgtggacaacagcagacaacccttaagggtgtagaagctgttatgtacatgggcacactttcttatgaacaatttaagaaaggtgttcagataccttgtacgtgtggtaaacaagctacaaaatatctagtacaacaggagtcaccttttgttatgatgtcagcaccacctgctcagtatgaacttaagcatggtacatttacttgtgctagtgagtacactggtaattaccagtgtggtcactataaacatataacttctaaagaaactttgtattgcatagacggtgctttacttacaaagtcctcagaatacaaaggtcctattacggatgttttctacaaagaaaacagttacacaacaaccataaaaccagttacttataaattggatggtgttgtttgtacagaaattgaccctaagttggacaattattataagaaagacaattcttatttcacagagcaaccaattgatcttgtaccaaaccaaccatatccaaacgcaagcttcgataattttaagtttgtatgtgataatatcaaatttgctgatgatttaaaccagttaactggttataagaaacctgcttcaagagagcttaaagttacatttttccctgacttaaatggtgatgtggtggctattgattataaacactacacaccctcttttaagaaaggagctaaattgttacataaacctattgtttggcatgttaacaatgcaactaataaagccacgtataaaccaaatacctggtgtatacgttgtctttggagcacaaaaccagttgaaacatcaaattcgtttgatgtactgaagtcagaggacgcgcagggaatggataatcttgcctgcgaagatctaaaaccagtctctgaagaagtagtggaaaatcctaccatacagaaagacgttcttgagtgtaatgtgaaaactaccgaagttgtaggagacattatacttaaaccagcaaataatagtttaaaaattacagaagaggttggccacacagatctaatggctgcttatgtagacaattctagtcttactattaagaaacctaatgaattatctagagtattaggtttgaaaacccttgctactcatggtttagctgctgttaatagtgtcccttgggatactatagctaattatgctaagccttttcttaacaaagttgttagtacaactactaacatagttacacggtgtttaaaccgtgtttgtactaattatatgccttatttctttactttattgctacaattgtgtacttttactagaagtacaaattctagaattaaagcatctatgccgactactatagcaaagaatactgttaagagtgtcggtaaattttgtctagaggcttcatttaattatttgaagtcacctaatttttctaaactgataaatattataatttggtttttactattaagtgtttgcctaggttctttaatctactcaaccgctgctttaggtgttttaatgtctaatttaggcatgccttcttactgtactggttacagagaaggctatttgaactctactaatgtcactattgcaacctactgtactggttctataccttgtagtgtttgtcttagtggtttagattctttagacacctatccttctttagaaactatacaaattaccatttcatcttttaaatgggatttaactgcttttggcttagttgcagagtggtttttggcatatattcttttcactaggtttttctatgtacttggattggctgcaatcatgcaattgtttttcagctattttgcagtacattttattagtaattcttggcttatgtggttaataattaatcttgtacaaatggccccgatttcagctatggttagaatgtacatcttctttgcatcattttattatgtatggaaaagttatgtgcatgttgtagacggttgtaattcatcaacttgtatgatgtgttacaaacgtaatagagcaacaagagtcgaatgtacaactattgttaatggtgttagaaggtccttttatgtctatgctaatggaggtaaaggcttttgcaaactacacaattggaattgtgttaattgtgatacattctgtgctggtagtacatttattagtgatgaagttgcgagagacttgtcactacagtttaaaagaccaataaatcctactgaccagtcttcttacatcgttgatagtgttacagtgaagaatggttccatccatctttactttgataaagctggtcaaaagacttatgaaagacattctctctctcattttgttaacttagacaacctgagagctaataacactaaaggttcattgcctattaatgttatagtttttgatggtaaatcaaaatgtgaagaatcatctgcaaaatcagcgtctgtttactacagtcagcttatgtgtcaacctatactgttactagatcaggcattagtgtctgatgttggtgatagtgcggaagttgcagttaaaatgtttgatgcttacgttaatacgttttcatcaacttttaacgtaccaatggaaaaactcaaaacactagttgcaactgcagaagctgaacttgcaaagaatgtgtccttagacaatgtcttatctacttttatttcagcagctcggcaagggtttgttgattcagatgtagaaactaaagatgttgttgaatgtcttaaattgtcacatcaatctgacatagaagttactggcgatagttgtaataactatatgctcacctataacaaagttgaaaacatgacaccccgtgaccttggtgcttgtattgactgtagtgcgcgtcatattaatgcgcaggtagcaaaaagtcacaacattgctttgatatggaacgttaaagatttcatgtcattgtctgaacaactacgaaaacaaatacgtagtgctgctaaaaagaataacttaccttttaagttgacatgtgcaactactagacaagttgttaatgttgtaacaacaaagatagcacttaagggtggtaaaattgttaataattggttgaagcagttaattaaagttacacttgtgttcctttttgttgctgctattttctatttaataacacctgttcatgtcatgtctaaacatactgacttttcaagtgaaatcataggatacaaggctattgatggtggtgtcactcgtgacatagcatctacagatacttgttttgctaacaaacatgctgattttgacacatggtttagccagcgtggtggtagttatactaatgacaaagcttgcccattgattgctgcagtcataacaagagaagtgggttttgtcgtgcctggtttgcctggcacgatattacgcacaactaatggtgactttttgcatttcttacctagagtttttagtgcagttggtaacatctgttacacaccatcaaaacttatagagtacactgactttgcaacatcagcttgtgttttggctgctgaatgtacaatttttaaagatgcttctggtaagccagtaccatattgttatgataccaatgtactagaaggttctgttgcttatgaaagtttacgccctgacacacgttatgtgctcatggatggctctattattcaatttcctaacacctaccttgaaggttctgttagagtggtaacaacttttgattctgagtactgtaggcacggcacttgtgaaagatcagaagctggtgtttgtgtatctactagtggtagatgggtacttaacaatgattattacagatctttaccaggagttttctgtggtgtagatgctgtaaatttacttactaatatgtttacaccactaattcaacctattggtgctttggacatatcagcatctatagtagctggtggtattgtagctatcgtagtaacatgccttgcctactattttatgaggtttagaagagcttttggtgaatacagtcatgtagttgcctttaatactttactattccttatgtcattcactgtactctgtttaacaccagtttactcattcttacctggtgtttattctgttatttacttgtacttgacattttatcttactaatgatgtttcttttttagcacatattcagtggatggttatgttcacacctttagtacctttctggataacaattgcttatatcatttgtatttccacaaagcatttctattggttctttagtaattacctaaagagacgtgtagtctttaatggtgtttcctttagtacttttgaagaagctgcgctgtgcacctttttgttaaataaagaaatgtatctaaagttgcgtagtgatgtgctattacctcttacgcaatataatagatacttagctctttataataagtacaagtattttagtggagcaatggatacaactagctacagagaagctgcttgttgtcatctcgcaaaggctctcaatgacttcagtaactcaggttctgatgttctttaccaaccaccacaaacctctatcacctcagctgttttgcagagtggttttagaaaaatggcattcccatctggtaaagttgagggttgtatggtacaagtaacttgtggtacaactacacttaacggtctttggcttgatgacgtagtttactgtccaagacatgtgatctgcacctctgaagacatgcttaaccctaattatgaagatttactcattcgtaagtctaatcataatttcttggtacaggctggtaatgttcaactcagggttattggacattctatgcaaaattgtgtacttaagcttaaggttgatacagccaatcctaagacacctaagtataagtttgttcgcattcaaccaggacagactttttcagtgttagcttgttacaatggttcaccatctggtgtttaccaatgtgctatgaggcccaatttcactattaagggttcattccttaatggttcatgtggtagtgttggttttaacatagattatgactgtgtctctttttgttacatgcaccatatggaattaccaactggagttcatgctggcacagacttagaaggtaacttttatggaccttttgttgacaggcaaacagcacaagcagctggtacggacacaactattacagttaatgttttagcttggttgtacgctgctgttataaatggagacaggtggtttctcaatcgatttaccacaactcttaatgactttaaccttgtggctatgaagtacaattatgaacctctaacacaagaccatgttgacatactaggacctctttctgctcaaactggaattgccgttttagatatgtgtgcttcattaaaagaattactgcaaaatggtatgaatggacgtaccatattgggtagtgctttattagaagatgaatttacaccttttgatgttgttagacaatgctcaggtgttactttccaaagtgcagtgaaaagaacaatcaagggtacacaccactggttgttactcacaattttgacttcacttttagttttagtccagagtactcaatggtctttgttcttttttttgtatgaaaatgcctttttaccttttgctatgggtattattgctatgtctgcttttgcaatgatgtttgtcaaacataagcatgcatttctctgtttgtttttgttaccttctcttgccactgtagcttattttaatatggtctatatgcctgctagttgggtgatgcgtattatgacatggttggatatggttgatactagtttgtctggttttaagctaaaagactgtgttatgtatgcatcagctgtagtgttactaatccttatgacagcaagaactgtgtatgatgatggtgctaggagagtgtggacacttatgaatgtcttgacactcgtttataaagtttattatggtaatgctttagatcaagccatttccatgtgggctcttataatctctgttacttctaactactcaggtgtagttacaactgtcatgtttttggccagaggtattgtttttatgtgtgttgagtattgccctattttcttcataactggtaatacacttcagtgtataatgctagtttattgtttcttaggctatttttgtacttgttactttggcctcttttgtttactcaaccgctactttagactgactcttggtgtttatgattacttagtttctacacaggagtttagatatatgaattcacagggactactcccacccaagaatagcatagatgccttcaaactcaacattaaattgttgggtgttggtggcaaaccttgtatcaaagtagccactgtacagtctaaaatgtcagatgtaaagtgcacatcagtagtcttactctcagttttgcaacaactcagagtagaatcatcatctaaattgtgggctcaatgtgtccagttacacaatgacattctcttagctaaagatactactgaagcctttgaaaaaatggtttcactactttctgttttgctttccatgcagggtgctgtagacataaacaagctttgtgaagaaatgctggacaacagggcaaccttacaagctatagcctcagagtttagttcccttccatcatatgcagcttttgctactgctcaagaagcttatgagcaggctgttgctaatggtgattctgaagttgttcttaaaaagttgaagaagtctttgaatgtggctaaatctgaatttgaccgtgatgcagccatgcaacgtaagttggaaaagatggctgatcaagctatgacccaaatgtataaacaggctagatctgaggacaagagggcaaaagttactagtgctatgcagacaatgcttttcactatgcttagaaagttggataatgatgcactcaacaacattatcaacaatgcaagagatggttgtgttcccttgaacataatacctcttacaacagcagccaaactaatggttgtcataccagactataacacatataaaaatacgtgtgatggtacaacatttacttatgcatcagcattgtgggaaatccaacaggttgtagatgcagatagtaaaattgttcaacttagtgaaattagtatggacaattcacctaatttagcatggcctcttattgtaacagctttaagggccaattctgctgtcaaattacagaataatgagcttagtcctgttgcactacgacagatgtcttgtgctgccggtactacacaaactgcttgcactgatgacaatgcgttagcttactacaacacaacaaagggaggtaggtttgtacttgcactgttatccgatttacaggatttgaaatgggctagattccctaagagtgatggaactggtactatctatacagaactggaaccaccttgtaggtttgttacagacacacctaaaggtcctaaagtgaagtatttatactttattaaaggattaaacaacctaaatagaggtatggtacttggtagtttagctgccacagtacgtctacaagctggtaatgcaacagaagtgcctgccaattcaactgtattatctttctgtgcttttgctgtagatgctgctaaagcttacaaagattatctagctagtgggggacaaccaatcactaattgtgttaagatgttgtgtacacacactggtactggtcaggcaataacagttacaccggaagccaatatggatcaagaatcctttggtggtgcatcgtgttgtctgtactgccgttgccacatagatcatccaaatcctaaaggattttgtgacttaaaaggtaagtatgtacaaatacctacaacttgtgctaatgaccctgtgggttttacacttaaaaacacagtctgtaccgtctgcggtatgtggaaaggttatggctgtagttgtgatcaactccgcgaacccatgcttcagtcagctgatgcacaatcgtttttaaacgggtttgcggtgtaagtgcagcccgtcttacaccgtgcggcacaggcactagtactgatgtcgtatacagggcttttgacatctacaatgataaagtagctggttttgctaaattcctaaaaactaattgttgtcgcttccaagaaaaggacgaagatgacaatttaattgattcttactttgtagttaagagacacactttctctaactaccaacatgaagaaacaatttataatttacttaaggattgtccagctgttgctaaacatgacttctttaagtttagaatagacggtgacatggtaccacatatatcacgtcaacgtcttactaaatacacaatggcagacctcgtctatgctttaaggcattttgatgaaggtaattgtgacacattaaaagaaatacttgtcacatacaattgttgtgatgatgattatttcaataaaaaggactggtatgattttgtagaaaacccagatatattacgcgtatacgccaacttaggtgaacgtgtacgccaagctttgttaaaaacagtacaattctgtgatgccatgcgaaatgctggtattgttggtgtactgacattagataatcaagatctcaatggtaactggtatgatttcggtgatttcatacaaaccacgccaggtagtggagttcctgttgtagattcttattattcattgttaatgcctatattaaccttgaccagggctttaactgcagagtcacatgttgacactgacttaacaaagccttacattaagtgggatttgttaaaatatgacttcacggaagagaggttaaaactctttgaccgttattttaaatattgggatcagacataccacccaaattgtgttaactgtttggatgacagatgcattctgcattgtgcaaactttaatgttttattctctacagtgttcccacctacaagttttggaccactagtgagaaaaatatttgttgatggtgttccatttgtagtttcaactggataccacttcagagagctaggtgttgtacataatcaggatgtaaacttacatagctctagacttagttttaaggaattacttgtgtatgctgctgaccctgctatgcacgctgcttctggtaatctattactagataaacgcactacgtgcttttcagtagctgcacttactaacaatgttgcttttcaaactgtcaaacccggtaattttaacaaagacttctatgactttgctgtgtctaagggtttctttaaggaaggaagttctgttgaattaaaacacttcttctttgctcaggatggtaatgctgctatcagcgattatgactactatcgttataatctaccaacaatgtgtgatatcagacaactactatttgtagttgaagttgttgataagtactttgattgttacgatggtggctgtattaatgctaaccaagtcatcgtcaacaacctagacaaatcagctggttttccatttaataaatggggtaaggctagactttattatgattcaatgagttatgaggatcaagatgcacttttcgcatatacaaaacgtaatgtcatccctactataactcaaatgaatcttaagtatgccattagtgcaaagaatagagctcgcaccgtagctggtgtctctatctgtagtactatgaccaatagacagtttcatcaaaaattattgaaatcaatagccgccactagaggagctactgtagtaattggaacaagcaaattctatggtggttggcacaacatgttaaaaactgtttatagtgatgtagaaaaccctcaccttatgggttgggattatcctaaatgtgatagagccatgcctaacatgcttagaattatggcctcacttgttcttgctcgcaaacatacaacgtgttgtagcttgtcacaccgtttctatagattagctaatgagtgtgctcaagtattgagtgaaatggtcatgtgtggcggttcactatatgttaaaccaggtggaacctcatcaggagatgccacaactgcttatgctaatagtgtttttaacatttgtcaagctgtcacggccaatgttaatgcacttttatctactgatggtaacaaaattgccgataagtatgtccgcaatttacaacacagactttatgagtgtctctatagaaatagagatgttgacacagactttgtgaatgagttttacgcatatttgcgtaaacatttctcaatgatgatactctctgacgatgctgttgtgtgtttcaatagcacttatgcatctcaaggtctagtggctagcataaagaactttaagtcagttctttattatcaaaacaatgtttttatgtctgaagcaaaatgttggactgagactgaccttactaaaggacctcatgaattttgctctcaacatacaatgctagttaaacagggtgatgattatgtgtaccttccttacccagatccatcaagaatcctaggggccggctgttttgtagatgatatcgtaaaaacagatggtacacttatgattgaacggttcgtgtctttagctatagatgcttacccacttactaaacatcctaatcaggagtatgctgatgtctttcatttgtacttacaatacataagaaagctacatgatgagttaacaggacacatgttagacatgtattctgttatgcttactaatgataacacttcaaggtattgggaacctgagttttatgaggctatgtacacaccgcatacagtcttacaggctgttggggcttgtgttctttgcaattcacagacttcattaagatgtggtgcttgcatacgtagaccattcttatgttgtaaatgctgttacgaccatgtcatatcaacatcacataaattagtcttgtctgttaatccgtatgtttgcaatgctccaggttgtgatgtcacagatgtgactcaactttacttaggaggtatgagctattattgtaaatcacataaaccacccattagttttccattgtgtgctaatggacaagtttttggtttatataaaaatacatgtgttggtagcgataatgttactgactttaatgcaattgcaacatgtgactggacaaatgctggtgattacattttagctaacacctgtactgaaagactcaagctttttgcagcagaaacgctcaaagctactgaggagacatttaaactgtcttatggtattgctactgtacgtgaagtgctgtctgacagagaattacatctttcatgggaagttggtaaacctagaccaccacttaaccgaaattatgtctttactggttatcgtgtaactaaaaacagtaaagtacaaataggagagtacacctttgaaaaaggtgactatggtgatgctgttgtttaccgaggtacaacaacttacaaattaaatgttggtgattattttgtgctgacatcacatacagtaatgccattaagtgcacctacactagtgccacaagagcactatgttagaattactggcttatacccaacactcaatatctcagatgagttttctagcaatgttgcaaattatcaaaaggttggtatgcaaaagtattctacactccagggaccacctggtactggtaagagtcattttgctattggcctagctctctactacccttctgctcgcatagtgtatacagcttgctctcatgccgctgttgatgcactatgtgagaaggcattaaaatatttgcctatagataaatgtagtagaattatacctgcacgtgctcgtgtagagtgttttgataaattcaaagtgaattcaacattagaacagtatgtcttttgtactgtaaatgcattgcctgagacgacagcagatatagttgtctttgatgaaatttcaatggccacaaattatgatttgagtgttgtcaatgccagattacgtgctaagcactatgtgtacattggcgaccctgctcaattacctgcaccacgcacattgctaactaagggcacactagaaccagaatatttcaattcagtgtgtagacttatgaaaactataggtccagacatgttcctcggaacttgtcggcgttgtcctgctgaaattgttgacactgtgagtgctttggtttatgataataagcttaaagcacataaagacaaatcagctcaatgctttaaaatgttttataagggtgttatcacgcatgatgtttcatctgcaattaacaggccacaaataggcgtggtaagagaattccttacacgtaaccctgcttggagaaaagctgtctttatttcaccttataattcacagaatgctgtagcctcaaagattttgggactaccaactcaaactgttgattcatcacagggctcagaatatgactatgtcatattcactcaaaccactgaaacagctcactcttgtaatgtaaacagatttaatgttgctattaccagagcaaaagtaggcatactttgcataatgtctgatagagacctttatgacaagttgcaatttacaagtcttgaaattccacgtaggaatgtggcaactttacaagctgaaaatgtaacaggactctttaaagattgtagtaaggtaatcactgggttacatcctacacaggcacctacacacctcagtgttgacactaaattcaaaactgaaggtttatgtgttgacatacctggcatacctaaggacatgacctatagaagactcatctctatgatgggttttaaaatgaattatcaagttaatggttaccctaacatgtttatcacccgcgaagaagctataagacatgtacgtgcatggattggcttcgatgtcgaggggtgtcatgctactagagaagctgttggtaccaatttacctttacagctaggtttttctacaggtgttaacctagttgctgtacctacaggttatgttgatacacctaataatacagatttttccagagttagtgctaaaccaccgcctggagatcaatttaaacacctcataccacttatgtacaaaggacttccttggaatgtagtgcgtataaagattgtacaaatgttaagtgacacacttaaaaatctctctgacagagtcgtatttgtcttatgggcacatggctttgagttgacatctatgaagtattttgtgaaaataggacctgagcgcacctgttgtctatgtgatagacgtgccacatgcttttccactgcttcagacacttatgcctgttggcatcattctattggatttgattacgtctataatccgtttatgattgatgttcaacaatggggttttacaggtaacctacaaagcaaccatgatctgtattgtcaagtccatggtaatgcacatgtagctagttgtgatgcaatcatgactaggtgtctagctgtccacgagtgctttgttaagcgtgttgactggactattgaatatcctataattggtgatgaactgaagattaatgcggcttgtagaaaggttcaacacatggttgttaaagctgcattattagcagacaaattcccagttcttcacgacattggtaaccctaaagctattaagtgtgtacctcaagctgatgtagaatggaagttctatgatgcacagccttgtagtgacaaagcttataaaatagaagaattattctattcttatgccacacattctgacaaattcacagatggtgtatgcctattttggaattgcaatgtcgatagatatcctgctaattccattgtttgtagatttgacactagagtgctatctaaccttaacttgcctggttgtgatggtggcagtttgtatgtaaataaacatgcattccacacaccagcttttgataaaagtgcttttgttaatttaaaacaattaccatttttctattactctgacagtccatgtgagtctcatggaaaacaagtagtgtcagatatagattatgtaccactaaagtctgctacgtgtataacacgttgcaatttaggtggtgctgtctgtagacatcatgctaatgagtacagattgtatctcgatgcttataacatgatgatctcagctggctttagcttgtgggtttacaaacaatttgatacttataacctctggaacacttttacaagacttcagagtttagaaaatgtggcttttaatgttgtaaataagggacactttgatggacaacagggtgaagtaccagtttctatcattaataacactgtttacacaaaagttgatggtgttgatgtagaattgtttgaaaataaaacaacattacctgttaatgtagcatttgagctttgggctaagcgcaacattaaaccagtaccagaggtgaaaatactcaataatttgggtgtggacattgctgctaatactgtgatctgggactacaaaagagatgctccagcacatatatctactattggtgtttgttctatgactgacatagccaagaaaccaactgaaacgatttgtgcaccactcactgtcttttttgatggtagagttgatggtcaagtagacttatttagaaatgcccgtaatggtgttcttattacagaaggtagtgttaaaggtttacaaccatctgtaggtcccaaacaagctagtcttaatggagtcacattaattggagaagccgtaaaaacacagttcaattattataagaaagttgatggtgttgtccaacaattacctgaaacttactttactcagagtagaaatttacaagaatttaaacccaggagtcaaatggaaattgatttcttagaattagctatggatgaattcattgaacggtataaattagaaggctatgccttcgaacatatcgtttatggagattttagtcatagtcagttaggtggtttacatctactgattggactagctaaacgttttaaggaatcaccttttgaattagaagattttattcctatggacagtacagttaaaaactatttcataacagatgcgcaaacaggttcatctaagtgtgtgtgttctgttattgatttattacttgatgattttgttgaaataataaaatcccaagatttatctgtagtttctaaggttgtcaaagtgactattgactatacagaaatttcatttatgctttggtgtaaagatggccatgtagaaacattttacccaaaattacaatctagtcaagcgtggcaaccgggtgttgctatgcctaatctttacaaaatgcaaagaatgctattagaaaagtgtgaccttcaaaattatggtgatagtgcaacattacctaaaggcataatgatgaatgtcgcaaaatatactcaactgtgtcaatatttaaacacattaacattagctgtaccctataatatgagagttatacattttggtgctggttctgataaaggagttgcaccaggtacagctgttttaagacagtggttgcctacgggtacgctgcttgtcgattcagatcttaatgactttgtctctgatgcagattcaactttgattggtgattgtgcaactgtacatacagctaataaatgggatctcattattagtgatatgtacgaccctaagactaaaaatgttacaaaagaaaatgactctaaagagggttttttcacttacatttgtgggtttatacaacaaaagctagctcttggaggttccgtggctataaagataacagaacattcttggaatgctgatctttataagctcatgggacacttcgcatggtggacagcctttgttactaatgtgaatgcgtcatcatctgaagcatttttaattggatgtaattatcttggcaaaccacgcgaacaaatagatggttatgtcatgcatgcaaattacatattttggaggaatacaaatccaattcagttgtcttcctattctttatttgacatgagtaaatttccccttaaattaaggggtactgctgttatgtctttaaaagaaggtcaaatcaatgatatgattttatctcttcttagtaaaggtagacttataattagagaaaacaacagagttgttatttctagtgatgttcttgttaacaactaaacgaacaatgtttgtttttcttgttttattgccactagtctctagtcagtgtgttaatcttacaaccagaactcaattaccccctgcatacactaattctttcacacgtggtgtttattaccctgacaaagttttcagatcctcagttttacattcaactcaggacttgttcttacctttcttttccaatgttacttggttccatgctatacatgtctctgggaccaatggtactaagaggtttgataaccctgtcctaccatttaatgatggtgtttattttgcttccactgagaagtctaacataataagaggctggatttttggtactactttagattcgaagacccagtccctacttattgttaataacgctactaatgttgttattaaagtctgtgaatttcaattttgtaatgatccatttttgggtgtttattaccacaaaaacaacaaaagttggatggaaagtgagttcagagtttattctagtgcgaataattgcacttttgaatatgtctctcagccttttcttatggaccttgaaggaaaacagggtaatttcaaaaatcttagggaatttgtgtttaagaatattgatggttattttaaaatatattctaagcacacgcctattaatttagtgcgtgatctccctcagggtttttcggctttagaaccattggtagatttgccaataggtattaacatcactaggtttcaaactttacttgctttacatagaagttatttgactcctggtgattcttcttcaggttggacagctggtgctgcagcttattatgtgggttatcttcaacctaggacttttctattaaaatataatgaaaatggaaccattacagatgctgtagactgtgcacttgaccctctctcagaaacaaagtgtacgttgaaatccttcactgtagaaaaaggaatctatcaaacttctaactttagagtccaaccaacagaatctattgttagatttcctaatattacaaacttgtgcccttttggtgaagtttttaacgccaccagatttgcatctgtttatgcttggaacaggaagagaatcagcaactgtgttgctgattattctgtcctatataattccgcatcattttccacttttaagtgttatggagtgtctcctactaaattaaatgatctctgctttactaatgtctatgcagattcatttgtaattagaggtgatgaagtcagacaaatcgctccagggcaaactggaaagattgctgattataattataaattaccagatgattttacaggctgcgttatagcttggaattctaacaatcttgattctaaggttggtggtaattataattacctgtatagattgtttaggaagtctaatctcaaaccttttgagagagatatttcaactgaaatctatcaggccggtagcacaccttgtaatggtgttgaaggttttaattgttactttcctttacaatcatatggtttccaacccactaatggtgttggttaccaaccatacagagtagtagtactttcttttgaacttctacatgcaccagcaactgtttgtggacctaaaaagtctactaatttggttaaaaacaaatgtgtcaatttcaacttcaatggtttaacaggcacaggtgttcttactgagtctaacaaaaagtttctgcctttccaacaatttggcagagacattgctgacactactgatgctgtccgtgatccacagacacttgagattcttgacattacaccatgttcttttggtggtgtcagtgttataacaccaggaacaaatacttctaaccaggttgctgttctttatcaggatgttaactgcacagaagtccctgttgctattcatgcagatcaacttactcctacttggcgtgtttattctacaggttctaatgtttttcaaacacgtgcaggctgtttaataggggctgaacatgtcaacaactcatatgagtgtgacatacccattggtgcaggtatatgcgctagttatcagactcagactaattctcctcggcgggcacgtagtgtagctagtcaatccatcattgcctacactatgtcacttggtgcagaaaattcagttgcttactctaataactctattgccatacccacaaattttactattagtgttaccacagaaattctaccagtgtctatgaccaagacatcagtagattgtacaatgtacatttgtggtgattcaactgaatgcagcaatcttttgttgcaatatggcagtttttgtacacaattaaaccgtgctttaactggaatagctgttgaacaagacaaaaacacccaagaagtttttgcacaagtcaaacaaatttacaaaacaccaccaattaaagattttggtggttttaatttttcacaaatattaccagatccatcaaaaccaagcaagaggtcatttattgaagatctacttttcaacaaagtgacacttgcagatgctggcttcatcaaacaatatggtgattgccttggtgatattgctgctagagacctcatttgtgcacaaaagtttaacggccttactgttttgccacctttgctcacagatgaaatgattgctcaatacacttctgcactgttagcgggtacaatcacttctggttggacctttggtgcaggtgctgcattacaaataccatttgctatgcaaatggcttataggtttaatggtattggagttacacagaatgttctctatgagaaccaaaaattgattgccaaccaatttaatagtgctattggcaaaattcaagactcactttcttccacagcaagtgcacttggaaaacttcaagatgtggtcaaccaaaatgcacaagctttaaacacgcttgttaaacaacttagctccaattttggtgcaatttcaagtgttttaaatgatatcctttcacgtcttgacaaagttgaggctgaagtgcaaattgataggttgatcacaggcagacttcaaagtttgcagacatatgtgactcaacaattaattagagctgcagaaatcagagcttctgctaatcttgctgctactaaaatgtcagagtgtgtacttggacaatcaaaaagagttgatttttgtggaaagggctatcatcttatgtccttccctcagtcagcacctcatggtgtagtcttcttgcatgtgacttatgtccctgcacaagaaaagaacttcacaactgctcctgccatttgtcatgatggaaaagcacactttcctcgtgaaggtgtctttgtttcaaatggcacacactggtttgtaacacaaaggaatttttatgaaccacaaatcattactacagacaacacatttgtgtctggtaactgtgatgttgtaataggaattgtcaacaacacagtttatgatcctttgcaacctgaattagactcattcaaggaggagttagataaatattttaagaatcatacatcaccagatgttgatttaggtgacatctctggcattaatgcttcagttgtaaacattcaaaaagaaattgaccgcctcaatgaggttgccaagaatttaaatgaatctctcatcgatctccaagaacttggaaagtatgagcagtatataaaatggccatggtacatttggctaggttttatagctggcttgattgccatagtaatggtgacaattatgctttgctgtatgaccagttgctgtagttgtctcaagggctgttgttcttgtggatcctgctgcaaatttgatgaagacgactctgagccagtgctcaaaggagtcaaattacattacacataaacgaacttatggatttgtttatgagaatcttcacaattggaactgtaactttgaagcaaggtgaaatcaaggatgctactccttcagattttgttcgcgctactgcaacgataccgatacaagcctcactccctttcggatggcttattgttggcgttgcacttcttgctgtttttcagagcgcttccaaaatcataaccctcaaaaagagatggcaactagcactctccaagggtgttcactttgtttgcaacttgctgttgttgtttgtaacagtttactcacaccttttgctcgttgctgctggccttgaagccccttttctctatctttatgctttagtctacttcttgcagagtataaactttgtaagaataataatgaggctttggctttgctggaaatgccgttccaaaaacccattactttatgatgccaactattttctttgctggcatactaattgttacgactattgtataccttacaatagtgtaacttcttcaattgtcattacttcaggtgatggcacaacaagtcctatttctgaacatgactaccagattggtggttatactgaaaaatgggaatctggagtaaaagactgtgttgtattacacagttacttcacttcagactattaccagctgtactcaactcaattgagtacagacactggtgttgaacatgttaccttcttcatctacaataaaattgttgatgagcctgaagaacatgtccaaattcacacaatcgacggttcatccggagttgttaatccagtaatggaaccaatttatgatgaaccgacgacgactactagcgtgcctttgtaagcacaagctgatgagtacgaacttatgtactcattcgtttcggaagagacaggtacgttaatagttaatagcgtacttctttttcttgctttcgtggtattcttgctagttacactagccatccttactgcgcttcgattgtgtgcgtactgctgcaatattgttaacgtgagtcttgtaaaaccttctttttacgtttactctcgtgttaaaaatctgaattcttctagagttcctgatcttctggtctaaacgaactaaatattatattagtttttctgtttggaactttaattttagccatggcagattccaacggtactattaccgttgaagagcttaaaaagctccttgaacaatggaacctagtaataggtttcctattccttacatggatttgtcttctacaatttgcctatgccaacaggaataggtttttgtatataattaagttaattttcctctggctgttatggccagtaactttagcttgttttgtgcttgctgctgtttacagaataaattggatcaccggtggaattgctatcgcaatggcttgtcttgtaggcttgatgtggctcagctacttcattgcttctttcagactgtttgcgcgtacgcgttccatgtggtcattcaatccagaaactaacattcttctcaacgtgccactccatggcactattctgaccagaccgcttctagaaagtgaactcgtaatcggagctgtgatccttcgtggacatcttcgtattgctggacaccatctaggacgctgtgacatcaaggacctgcctaaagaaatcactgttgctacatcacgaacgctttcttattacaaattgggagcttcgcagcgtgtagcaggtgactcaggttttgctgcatacagtcgctacaggattggcaactataaattaaacacagaccattccagtagcagtgacaatattgctttgcttgtacagtaagtgacaacagatgtttcatctcgttgactttcaggttactatagcagagatattactaattattatgaggacttttaaagtttccatttggaatcttgattacatcataaacctcataattaaaaatttatctaagtcactaactgagaataaatattctcaattagatgaagagcaaccaatggagattgattaaacgaacatgaaaattattcttttcttggcactgataacactcgctacttgtgagctttatcactaccaagagtgtgttagaggtacaacagtacttttaaaagaaccttgctcttctggaacatacgagggcaattcaccatttcatcctctagctgataacaaatttgcactgacttgctttagcactcaatttgcttttgcttgtcctgacggcgtaaaacacgtctatcagttacgtgccagatcagtttcacctaaactgttcatcagacaagaggaagttcaagaactttactctccaatttttcttattgttgcggcaatagtgtttataacactttgcttcacactcaaaagaaagacagaatgattgaactttcattaattgacttctatttgtgctttttagcctttctgctattccttgttttaattatgcttattatcttttggttctcacttgaactgcaagatcataatgaaacttgtcacgcctaaacgaacatgaaatttcttgttttcttaggaatcatcacaactgtagctgcatttcaccaagaatgtagtttacagtcatgtactcaacatcaaccatatgtagttgatgacccgtgtcctattcacttctattctaaatggtatattagagtaggagctagaaaatcagcacctttaattgaattgtgcgtggatgaggctggttctaaatcacccattcagtacatcgatatcggtaattatacagtttcctgtttaccttttacaattaattgccaggaacctaaattgggtagtcttgtagtgcgttgttcgttctatgaagactttttagagtatcatgacgttcgtgttgttttagatttcatctaaacgaacaaactaaaatgtctgataatggaccccaaaatcagcgaaatgcaccccgcattacgtttggtggaccctcagattcaactggcagtaaccagaatggagaacgcagtggggcgcgatcaaaacaacgtcggccccaaggtttacccaataatactgcgtcttggttcaccgctctcactcaacatggcaaggaagaccttaaattccctcgaggacaaggcgttccaattaacaccaatagcagtccagatgaccaaattggctactaccgaagagctaccagacgaattcgtggtggtgacggtaaaatgaaagatctcagtccaagatggtatttctactacctaggaactgggccagaagctggacttccctatggtgctaacaaagacggcatcatatgggttgcaactgagggagccttgaatacaccaaaagatcacattggcacccgcaatcctgctaacaatgctgcaatcgtgctacaacttcctcaaggaacaacattgccaaaaggcttctacgcagaagggagcagaggcggcagtcaagcctcttctcgttcctcatcacgtagtcgcaacagttcaagaaattcaactccaggcagcagtaggggaacttctcctgctagaatggctggcaatggcggtgatgctgctcttgctttgctgctgcttgacagattgaaccagcttgagagcaaaatgtctggtaaaggccaacaacaacaaggccaaactgtcactaagaaatctgctgctgaggcttctaagaagcctcggcaaaaacgtactgccactaaagcatacaatgtaacacaagctttcggcagacgtggtccagaacaaacccaaggaaattttggggaccaggaactaatcagacaaggaactgattacaaacattggccgcaaattgcacaatttgcccccagcgcttcagcgttcttcggaatgtcgcgcattggcatggaagtcacaccttcgggaacgtggttgacctacacaggtgccatcaaattggatgacaaagatccaaatttcaaagatcaagtcattttgctgaataagcatattgacgcatacaaaacattcccaccaacagagcctaaaaaggacaaaaagaagaaggctgatgaaactcaagccttaccgcagagacagaagaaacagcaaactgtgactcttcttcctgctgcagatttggatgatttctccaaacaattgcaacaatccatgagcagtgctgactcaactcaggcctaaactcatgcagaccacacaaggcagatgggctatataaacgttttcgcttttccgtttacgatatatagtctactcttgtgcagaatgaattctcgtaactacatagcacaagtagatgtagttaactttaatctcacatagcaatctttaatcagtgtgtaacattagggaggacttgaaagagccaccacattttcaccgaggccacgcggagtacgatcgagtgtacagtgaacaatgctagggagagctgcctatatggaagagccctaatgtgtaaaattaattttagtagtgctatccccatgtgattttaatagcttcttaggagaatgacaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaa";
		List<char> rna_messenger = new List<char>();

		for (int i = 0; i < dna_covid19.Length; i++)
		{
			switch (dna_covid19[i])
			{
				case 'a':
					rna_messenger.Add('u');
					break;
				case 't':
					rna_messenger.Add('a');
					break;
				case 'c':
					rna_messenger.Add('g');
					break;
				case 'g':
					rna_messenger.Add('c');
					break;
				default:
					Console.WriteLine("You have an error in your DNA nucleotides at position : {i} -> '{dna_covid19[i]}' you necessarily have one of these letters : 'A,T,C,G' otherwise it's not DNA.");
					return rna_messenger;
			}
		}
		return rna_messenger;
	}

	public static List<char> Rna_Translation(string rna_msg)
	{
		List<char> rna_messenger = new List<char>();

		for (int i = 0; i < rna_msg.Length; i++)
		{
			switch (rna_msg[i])
			{
				case 'u':
					rna_messenger.Add('a');
					break;
				case 'a':
					rna_messenger.Add('u');
					break;
				case 'g':
					rna_messenger.Add('c');
					break;
				case 'c':
					rna_messenger.Add('g');
					break;
			}
		}
		return rna_messenger;
	}

	public static List<char> RnaToAminoAcid(string rna_translated, int start, int end)
	{
		List<char> amino_acid = new List<char>();
		//I created a boolean to optimize the code when an amino acid is found
		//we are not trying to test other methods and go directly to the break;
		//to continue the loop
		bool status = false;

		for (int i = start; i < end; i = i+3)
		{
			if (i == (end - 3))
				break;

			char[] arr = { rna_translated[i + 1], rna_translated[i + 2] };

			switch (rna_translated[i])
			{
				case 'u':
					//There are comments bellow because there are no amino acids for these
					//nucleotides combinations you should look at the picture in the README
					//file if you want more information
					status =
					Condition(arr, amino_acid, 'u', 'g', 'L') ||
					Condition(arr, amino_acid, 'u', 'a', 'L') ||
					Condition(arr, amino_acid, 'u', 'c', 'F') ||
					Condition(arr, amino_acid, 'u', 'u', 'F') ||

					Condition(arr, amino_acid, 'g', 'g', 'W') ||
					//Condition(arr, amino_acid, 'g', 'a', '\0') ||
					Condition(arr, amino_acid, 'g', 'c', 'C') ||
					Condition(arr, amino_acid, 'g', 'u', 'C') ||

					Condition(arr, amino_acid, 'c', 'g', 'S') ||
					Condition(arr, amino_acid, 'c', 'a', 'S') ||
					Condition(arr, amino_acid, 'c', 'c', 'S') ||
					Condition(arr, amino_acid, 'c', 'u', 'S') ||

					//Condition(arr, amino_acid, 'a', 'g', '\0') ||
					//Condition(arr, amino_acid, 'a', 'a', '\0') ||
					Condition(arr, amino_acid, 'a', 'c', 'Y') ||
					Condition(arr, amino_acid, 'a', 'u', 'Y');
					break;
				case 'a':
					status =
					Condition(arr, amino_acid, 'u', 'g', 'M') ||
					Condition(arr, amino_acid, 'u', 'a', 'I') ||
					Condition(arr, amino_acid, 'u', 'c', 'I') ||
					Condition(arr, amino_acid, 'u', 'u', 'I') ||

					Condition(arr, amino_acid, 'g', 'g', 'R') ||
					Condition(arr, amino_acid, 'g', 'a', 'R') ||
					Condition(arr, amino_acid, 'g', 'c', 'S') ||
					Condition(arr, amino_acid, 'g', 'u', 'S') ||

					Condition(arr, amino_acid, 'c', 'g', 'T') ||
					Condition(arr, amino_acid, 'c', 'a', 'T') ||
					Condition(arr, amino_acid, 'c', 'c', 'T') ||
					Condition(arr, amino_acid, 'c', 'u', 'T') ||

					Condition(arr, amino_acid, 'a', 'g', 'K') ||
					Condition(arr, amino_acid, 'a', 'a', 'K') ||
					Condition(arr, amino_acid, 'a', 'c', 'N') ||
					Condition(arr, amino_acid, 'a', 'u', 'N');
					break;
				case 'g':
					status =
					Condition(arr, amino_acid, 'u', 'g', 'V') ||
					Condition(arr, amino_acid, 'u', 'a', 'V') ||
					Condition(arr, amino_acid, 'u', 'c', 'V') ||
					Condition(arr, amino_acid, 'u', 'u', 'V') ||

					Condition(arr, amino_acid, 'g', 'g', 'G') ||
					Condition(arr, amino_acid, 'g', 'a', 'G') ||
					Condition(arr, amino_acid, 'g', 'c', 'G') ||
					Condition(arr, amino_acid, 'g', 'u', 'G') ||

					Condition(arr, amino_acid, 'c', 'g', 'A') ||
					Condition(arr, amino_acid, 'c', 'a', 'A') ||
					Condition(arr, amino_acid, 'c', 'c', 'A') ||
					Condition(arr, amino_acid, 'c', 'u', 'A') ||

					Condition(arr, amino_acid, 'a', 'g', 'E') ||
					Condition(arr, amino_acid, 'a', 'a', 'E') ||
					Condition(arr, amino_acid, 'a', 'c', 'D') ||
					Condition(arr, amino_acid, 'a', 'u', 'D');
					break;
				case 'c':
					status =
					Condition(arr, amino_acid, 'u', 'g', 'L') ||
					Condition(arr, amino_acid, 'u', 'a', 'L') ||
					Condition(arr, amino_acid, 'u', 'c', 'L') ||
					Condition(arr, amino_acid, 'u', 'u', 'L') ||

					Condition(arr, amino_acid, 'g', 'g', 'R') ||
					Condition(arr, amino_acid, 'g', 'a', 'R') ||
					Condition(arr, amino_acid, 'g', 'c', 'R') ||
					Condition(arr, amino_acid, 'g', 'u', 'R') ||

					Condition(arr, amino_acid, 'c', 'g', 'P') ||
					Condition(arr, amino_acid, 'c', 'a', 'P') ||
					Condition(arr, amino_acid, 'c', 'c', 'P') ||
					Condition(arr, amino_acid, 'c', 'u', 'P') ||

					Condition(arr, amino_acid, 'a', 'g', 'Q') ||
					Condition(arr, amino_acid, 'a', 'a', 'Q') ||
					Condition(arr, amino_acid, 'a', 'c', 'H') ||
					Condition(arr, amino_acid, 'a', 'u', 'H');
					break;
			}
		}
		return amino_acid;
	}

	public static bool Condition(char[] nucleotide, List<char> amino_acid, char expected_nucleotide1, char expected_nucleotide2, char new_amino_acid)
	{
		if (nucleotide[0] == expected_nucleotide1)
		{
			if (nucleotide[1] == expected_nucleotide2)
			{
				amino_acid.Add(new_amino_acid);
				return true;
			}
		}
		return false;
	}
}