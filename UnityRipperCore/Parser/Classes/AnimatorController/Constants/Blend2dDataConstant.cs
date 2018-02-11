﻿using System;
using System.Collections.Generic;
using UnityRipper.Exporter.YAML;

namespace UnityRipper.Classes.AnimatorControllers
{
	public sealed class Blend2dDataConstant : IStreamReadable, IYAMLExportable
	{
		public void Read(EndianStream stream)
		{
			m_childPositionArray = stream.ReadArray<Vector2f>();
			m_childMagnitudeArray = stream.ReadSingleArray();
			m_childPairVectorArray = stream.ReadArray<Vector2f>();
			m_childPairAvgMagInvArray = stream.ReadSingleArray();
			m_childNeighborListArray = stream.ReadArray<MotionNeighborList>();
		}

		public YAMLNode ExportYAML()
		{
			throw new NotSupportedException();
		}

		public IReadOnlyList<Vector2f> ChildPositionArray => m_childPositionArray;
		public IReadOnlyList<float> ChildMagnitudeArray => m_childMagnitudeArray;
		public IReadOnlyList<Vector2f> ChildPairVectorArray => m_childPairVectorArray;
		public IReadOnlyList<float> ChildPairAvgMagInvArray => m_childPairAvgMagInvArray;
		public IReadOnlyList<MotionNeighborList> ChildNeighborListArray => m_childNeighborListArray;

		private Vector2f[] m_childPositionArray;
		private float[] m_childMagnitudeArray;
		private Vector2f[] m_childPairVectorArray;
		private float[] m_childPairAvgMagInvArray;
		private MotionNeighborList[] m_childNeighborListArray;
	}
}
