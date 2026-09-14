using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WateryTart.MusicAssistant.Messages
{
	public static partial class Commands
	{
		public const string AudioAnalysisGetWaveform = "audio_analysis/wave_form";
		public const string AudioAnalysisCoverage = "audio_analysis/coverage";
		public const string AudioAnalysisFailures = "audio_analysis/failures";
		public const string AudioAnalysisFailuresClear = "audio_analysis/failures/clear";
	}
}
