﻿using System.Collections.Generic;

namespace UnityRipper.Classes.AnimationClips
{
	public sealed class DenseClip : IStreamReadable
	{
		public void Read(EndianStream stream)
		{
			FrameCount = stream.ReadInt32();
			CurveCount = stream.ReadUInt32();
			SampleRate = stream.ReadSingle();
			BeginTime = stream.ReadSingle();

			m_sampleArray = stream.ReadSingleArray();
		}

		public bool IsValid => SampleArray.Count > 0;

		public int FrameCount { get; private set; }
		public uint CurveCount { get; private set; }
		public float SampleRate { get; private set; }
		public float BeginTime { get; private set; }
		public IReadOnlyList<float> SampleArray => m_sampleArray;

		private float[] m_sampleArray;
	}
}
