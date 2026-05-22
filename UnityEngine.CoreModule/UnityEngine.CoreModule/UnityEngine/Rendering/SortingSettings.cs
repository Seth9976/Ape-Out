using System;
using Il2CppSystem;

namespace UnityEngine.Rendering
{
	// Token: 0x020002C2 RID: 706
	public struct SortingSettings
	{
		// Token: 0x170006FE RID: 1790
		// (get) Token: 0x060022C9 RID: 8905 RVA: 0x00078610 File Offset: 0x00076810
		// (set) Token: 0x060022CA RID: 8906 RVA: 0x000129B4 File Offset: 0x00010BB4
		public Matrix4x4 worldToCameraMatrix
		{
			get
			{
				return this.m_WorldToCameraMatrix;
			}
			set
			{
				this.m_WorldToCameraMatrix = value;
			}
		}

		// Token: 0x170006FF RID: 1791
		// (get) Token: 0x060022CB RID: 8907 RVA: 0x00078628 File Offset: 0x00076828
		// (set) Token: 0x060022CC RID: 8908 RVA: 0x000129BE File Offset: 0x00010BBE
		public Vector3 cameraPosition
		{
			get
			{
				return this.m_CameraPosition;
			}
			set
			{
				this.m_CameraPosition = value;
			}
		}

		// Token: 0x17000700 RID: 1792
		// (get) Token: 0x060022CD RID: 8909 RVA: 0x00078640 File Offset: 0x00076840
		// (set) Token: 0x060022CE RID: 8910 RVA: 0x000129C8 File Offset: 0x00010BC8
		public Vector3 customAxis
		{
			get
			{
				return this.m_CustomAxis;
			}
			set
			{
				this.m_CustomAxis = value;
			}
		}

		// Token: 0x17000701 RID: 1793
		// (get) Token: 0x060022CF RID: 8911 RVA: 0x00078658 File Offset: 0x00076858
		// (set) Token: 0x060022D0 RID: 8912 RVA: 0x000129D2 File Offset: 0x00010BD2
		public SortingCriteria criteria
		{
			get
			{
				return this.m_Criteria;
			}
			set
			{
				this.m_Criteria = value;
			}
		}

		// Token: 0x17000702 RID: 1794
		// (get) Token: 0x060022D1 RID: 8913 RVA: 0x00078670 File Offset: 0x00076870
		// (set) Token: 0x060022D2 RID: 8914 RVA: 0x000129DC File Offset: 0x00010BDC
		public DistanceMetric distanceMetric
		{
			get
			{
				return this.m_DistanceMetric;
			}
			set
			{
				this.m_DistanceMetric = value;
			}
		}

		// Token: 0x060022D3 RID: 8915 RVA: 0x00078688 File Offset: 0x00076888
		public bool Equals(SortingSettings other)
		{
			return this.m_WorldToCameraMatrix.Equals(other.m_WorldToCameraMatrix) && this.m_CameraPosition.Equals(other.m_CameraPosition) && this.m_CustomAxis.Equals(other.m_CustomAxis) && this.m_Criteria == other.m_Criteria && this.m_DistanceMetric == other.m_DistanceMetric && this.m_PreviousVPMatrix.Equals(other.m_PreviousVPMatrix) && this.m_NonJitteredVPMatrix.Equals(other.m_NonJitteredVPMatrix);
		}

		// Token: 0x060022D4 RID: 8916 RVA: 0x00078718 File Offset: 0x00076918
		public override bool Equals(Object obj)
		{
			bool flag = obj == null;
			return !flag && obj is SortingSettings && this.Equals((SortingSettings)obj);
		}

		// Token: 0x060022D5 RID: 8917 RVA: 0x00078750 File Offset: 0x00076950
		public override int GetHashCode()
		{
			int num = this.m_WorldToCameraMatrix.GetHashCode();
			num = (num * 397) ^ this.m_CameraPosition.GetHashCode();
			num = (num * 397) ^ this.m_CustomAxis.GetHashCode();
			num = (num * 397) ^ (int)this.m_Criteria;
			num = (num * 397) ^ (int)this.m_DistanceMetric;
			num = (num * 397) ^ this.m_PreviousVPMatrix.GetHashCode();
			return (num * 397) ^ this.m_NonJitteredVPMatrix.GetHashCode();
		}

		// Token: 0x060022D6 RID: 8918 RVA: 0x000787FC File Offset: 0x000769FC
		public static bool operator ==(SortingSettings left, SortingSettings right)
		{
			return left.Equals(right);
		}

		// Token: 0x060022D7 RID: 8919 RVA: 0x00078818 File Offset: 0x00076A18
		public static bool operator !=(SortingSettings left, SortingSettings right)
		{
			return !left.Equals(right);
		}

		// Token: 0x04001DD6 RID: 7638
		public Matrix4x4 m_WorldToCameraMatrix;

		// Token: 0x04001DD7 RID: 7639
		public Vector3 m_CameraPosition;

		// Token: 0x04001DD8 RID: 7640
		public Vector3 m_CustomAxis;

		// Token: 0x04001DD9 RID: 7641
		public SortingCriteria m_Criteria;

		// Token: 0x04001DDA RID: 7642
		public DistanceMetric m_DistanceMetric;

		// Token: 0x04001DDB RID: 7643
		public Matrix4x4 m_PreviousVPMatrix;

		// Token: 0x04001DDC RID: 7644
		public Matrix4x4 m_NonJitteredVPMatrix;
	}
}
