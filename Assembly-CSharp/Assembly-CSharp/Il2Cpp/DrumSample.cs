using System;
using Il2CppDrumSampleInfo;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using UnityEngine;

namespace Il2Cpp
{
	// Token: 0x02000008 RID: 8
	[Serializable]
	public class DrumSample : ScriptableObject
	{
		// Token: 0x06000084 RID: 132 RVA: 0x00035C54 File Offset: 0x00033E54
		// Note: this type is marked as 'beforefieldinit'.
		static DrumSample()
		{
			Il2CppClassPointerStore<DrumSample>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "", "DrumSample");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<DrumSample>.NativeClassPtr);
			DrumSample.NativeFieldInfoPtr_SamplePack = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DrumSample>.NativeClassPtr, "SamplePack");
			DrumSample.NativeFieldInfoPtr_Drum = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DrumSample>.NativeClassPtr, "Drum");
			DrumSample.NativeFieldInfoPtr_Mic = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DrumSample>.NativeClassPtr, "Mic");
			DrumSample.NativeFieldInfoPtr_RoundRobin = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DrumSample>.NativeClassPtr, "RoundRobin");
			DrumSample.NativeFieldInfoPtr_TotalRoundRobinCount = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DrumSample>.NativeClassPtr, "TotalRoundRobinCount");
			DrumSample.NativeFieldInfoPtr_TotalVelocityLevelsCount = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DrumSample>.NativeClassPtr, "TotalVelocityLevelsCount");
			DrumSample.NativeFieldInfoPtr_VelocityLow = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DrumSample>.NativeClassPtr, "VelocityLow");
			DrumSample.NativeFieldInfoPtr_VelocityHigh = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DrumSample>.NativeClassPtr, "VelocityHigh");
			DrumSample.NativeFieldInfoPtr_Articulation = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DrumSample>.NativeClassPtr, "Articulation");
			DrumSample.NativeFieldInfoPtr_FileName = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DrumSample>.NativeClassPtr, "FileName");
			DrumSample.NativeFieldInfoPtr_AssetPath = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DrumSample>.NativeClassPtr, "AssetPath");
			DrumSample.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DrumSample>.NativeClassPtr, 100663329);
		}

		// Token: 0x06000085 RID: 133 RVA: 0x00035D74 File Offset: 0x00033F74
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 30554, XrefRangeEnd = 30555, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe DrumSample()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<DrumSample>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DrumSample.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000086 RID: 134 RVA: 0x000025D5 File Offset: 0x000007D5
		public DrumSample(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x17000032 RID: 50
		// (get) Token: 0x06000087 RID: 135 RVA: 0x00035DB0 File Offset: 0x00033FB0
		// (set) Token: 0x06000088 RID: 136 RVA: 0x000025DE File Offset: 0x000007DE
		public unsafe SamplePack SamplePack
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DrumSample.NativeFieldInfoPtr_SamplePack);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DrumSample.NativeFieldInfoPtr_SamplePack)) = value;
			}
		}

		// Token: 0x17000033 RID: 51
		// (get) Token: 0x06000089 RID: 137 RVA: 0x00035DD8 File Offset: 0x00033FD8
		// (set) Token: 0x0600008A RID: 138 RVA: 0x000025F9 File Offset: 0x000007F9
		public unsafe Drum Drum
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DrumSample.NativeFieldInfoPtr_Drum);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DrumSample.NativeFieldInfoPtr_Drum)) = value;
			}
		}

		// Token: 0x17000034 RID: 52
		// (get) Token: 0x0600008B RID: 139 RVA: 0x00035E00 File Offset: 0x00034000
		// (set) Token: 0x0600008C RID: 140 RVA: 0x00002614 File Offset: 0x00000814
		public unsafe Mic Mic
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DrumSample.NativeFieldInfoPtr_Mic);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DrumSample.NativeFieldInfoPtr_Mic)) = value;
			}
		}

		// Token: 0x17000035 RID: 53
		// (get) Token: 0x0600008D RID: 141 RVA: 0x00035E28 File Offset: 0x00034028
		// (set) Token: 0x0600008E RID: 142 RVA: 0x0000262F File Offset: 0x0000082F
		public unsafe int RoundRobin
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DrumSample.NativeFieldInfoPtr_RoundRobin);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DrumSample.NativeFieldInfoPtr_RoundRobin)) = value;
			}
		}

		// Token: 0x17000036 RID: 54
		// (get) Token: 0x0600008F RID: 143 RVA: 0x00035E50 File Offset: 0x00034050
		// (set) Token: 0x06000090 RID: 144 RVA: 0x0000264A File Offset: 0x0000084A
		public unsafe int TotalRoundRobinCount
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DrumSample.NativeFieldInfoPtr_TotalRoundRobinCount);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DrumSample.NativeFieldInfoPtr_TotalRoundRobinCount)) = value;
			}
		}

		// Token: 0x17000037 RID: 55
		// (get) Token: 0x06000091 RID: 145 RVA: 0x00035E78 File Offset: 0x00034078
		// (set) Token: 0x06000092 RID: 146 RVA: 0x00002665 File Offset: 0x00000865
		public unsafe int TotalVelocityLevelsCount
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DrumSample.NativeFieldInfoPtr_TotalVelocityLevelsCount);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DrumSample.NativeFieldInfoPtr_TotalVelocityLevelsCount)) = value;
			}
		}

		// Token: 0x17000038 RID: 56
		// (get) Token: 0x06000093 RID: 147 RVA: 0x00035EA0 File Offset: 0x000340A0
		// (set) Token: 0x06000094 RID: 148 RVA: 0x00002680 File Offset: 0x00000880
		public unsafe int VelocityLow
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DrumSample.NativeFieldInfoPtr_VelocityLow);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DrumSample.NativeFieldInfoPtr_VelocityLow)) = value;
			}
		}

		// Token: 0x17000039 RID: 57
		// (get) Token: 0x06000095 RID: 149 RVA: 0x00035EC8 File Offset: 0x000340C8
		// (set) Token: 0x06000096 RID: 150 RVA: 0x0000269B File Offset: 0x0000089B
		public unsafe int VelocityHigh
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DrumSample.NativeFieldInfoPtr_VelocityHigh);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DrumSample.NativeFieldInfoPtr_VelocityHigh)) = value;
			}
		}

		// Token: 0x1700003A RID: 58
		// (get) Token: 0x06000097 RID: 151 RVA: 0x00035EF0 File Offset: 0x000340F0
		// (set) Token: 0x06000098 RID: 152 RVA: 0x000026B6 File Offset: 0x000008B6
		public unsafe Articulation Articulation
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DrumSample.NativeFieldInfoPtr_Articulation);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DrumSample.NativeFieldInfoPtr_Articulation)) = value;
			}
		}

		// Token: 0x1700003B RID: 59
		// (get) Token: 0x06000099 RID: 153 RVA: 0x00035F18 File Offset: 0x00034118
		// (set) Token: 0x0600009A RID: 154 RVA: 0x000026D1 File Offset: 0x000008D1
		public unsafe string FileName
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DrumSample.NativeFieldInfoPtr_FileName);
				return IL2CPP.Il2CppStringToManaged(*intPtr);
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(DrumSample.NativeFieldInfoPtr_FileName), IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x1700003C RID: 60
		// (get) Token: 0x0600009B RID: 155 RVA: 0x00035F40 File Offset: 0x00034140
		// (set) Token: 0x0600009C RID: 156 RVA: 0x000026F0 File Offset: 0x000008F0
		public unsafe string AssetPath
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DrumSample.NativeFieldInfoPtr_AssetPath);
				return IL2CPP.Il2CppStringToManaged(*intPtr);
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(DrumSample.NativeFieldInfoPtr_AssetPath), IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x04000049 RID: 73
		private static readonly IntPtr NativeFieldInfoPtr_SamplePack;

		// Token: 0x0400004A RID: 74
		private static readonly IntPtr NativeFieldInfoPtr_Drum;

		// Token: 0x0400004B RID: 75
		private static readonly IntPtr NativeFieldInfoPtr_Mic;

		// Token: 0x0400004C RID: 76
		private static readonly IntPtr NativeFieldInfoPtr_RoundRobin;

		// Token: 0x0400004D RID: 77
		private static readonly IntPtr NativeFieldInfoPtr_TotalRoundRobinCount;

		// Token: 0x0400004E RID: 78
		private static readonly IntPtr NativeFieldInfoPtr_TotalVelocityLevelsCount;

		// Token: 0x0400004F RID: 79
		private static readonly IntPtr NativeFieldInfoPtr_VelocityLow;

		// Token: 0x04000050 RID: 80
		private static readonly IntPtr NativeFieldInfoPtr_VelocityHigh;

		// Token: 0x04000051 RID: 81
		private static readonly IntPtr NativeFieldInfoPtr_Articulation;

		// Token: 0x04000052 RID: 82
		private static readonly IntPtr NativeFieldInfoPtr_FileName;

		// Token: 0x04000053 RID: 83
		private static readonly IntPtr NativeFieldInfoPtr_AssetPath;

		// Token: 0x04000054 RID: 84
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
	}
}
