using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppSystem;

namespace UnityEngine.Timeline
{
	// Token: 0x0200000B RID: 11
	public static class MatchTargetFieldConstants : Object
	{
		// Token: 0x06000076 RID: 118 RVA: 0x00005EAC File Offset: 0x000040AC
		// Note: this type is marked as 'beforefieldinit'.
		static MatchTargetFieldConstants()
		{
			Il2CppClassPointerStore<MatchTargetFieldConstants>.NativeClassPtr = IL2CPP.GetIl2CppClass("Unity.Timeline.dll", "UnityEngine.Timeline", "MatchTargetFieldConstants");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<MatchTargetFieldConstants>.NativeClassPtr);
			MatchTargetFieldConstants.NativeFieldInfoPtr_All = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MatchTargetFieldConstants>.NativeClassPtr, "All");
			MatchTargetFieldConstants.NativeFieldInfoPtr_None = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MatchTargetFieldConstants>.NativeClassPtr, "None");
			MatchTargetFieldConstants.NativeFieldInfoPtr_Position = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MatchTargetFieldConstants>.NativeClassPtr, "Position");
			MatchTargetFieldConstants.NativeFieldInfoPtr_Rotation = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MatchTargetFieldConstants>.NativeClassPtr, "Rotation");
			MatchTargetFieldConstants.NativeMethodInfoPtr_HasAny_Public_Static_Boolean_MatchTargetFields_MatchTargetFields_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MatchTargetFieldConstants>.NativeClassPtr, 100663366);
			MatchTargetFieldConstants.NativeMethodInfoPtr_Toggle_Public_Static_MatchTargetFields_MatchTargetFields_MatchTargetFields_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MatchTargetFieldConstants>.NativeClassPtr, 100663367);
		}

		// Token: 0x06000077 RID: 119 RVA: 0x00005F54 File Offset: 0x00004154
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 472785, XrefRangeEnd = 472789, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static bool HasAny(this MatchTargetFields me, MatchTargetFields fields)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref me;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref fields;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MatchTargetFieldConstants.NativeMethodInfoPtr_HasAny_Public_Static_Boolean_MatchTargetFields_MatchTargetFields_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06000078 RID: 120 RVA: 0x00005FA0 File Offset: 0x000041A0
		[CallerCount(0)]
		public unsafe static MatchTargetFields Toggle(this MatchTargetFields me, MatchTargetFields flag)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref me;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref flag;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MatchTargetFieldConstants.NativeMethodInfoPtr_Toggle_Public_Static_MatchTargetFields_MatchTargetFields_MatchTargetFields_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06000079 RID: 121 RVA: 0x000022FA File Offset: 0x000004FA
		public MatchTargetFieldConstants(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x17000029 RID: 41
		// (get) Token: 0x0600007A RID: 122 RVA: 0x00005FEC File Offset: 0x000041EC
		// (set) Token: 0x0600007B RID: 123 RVA: 0x00002303 File Offset: 0x00000503
		public unsafe static MatchTargetFields All
		{
			get
			{
				MatchTargetFields matchTargetFields;
				IL2CPP.il2cpp_field_static_get_value(MatchTargetFieldConstants.NativeFieldInfoPtr_All, (void*)(&matchTargetFields));
				return matchTargetFields;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(MatchTargetFieldConstants.NativeFieldInfoPtr_All, (void*)(&value));
			}
		}

		// Token: 0x1700002A RID: 42
		// (get) Token: 0x0600007C RID: 124 RVA: 0x00006008 File Offset: 0x00004208
		// (set) Token: 0x0600007D RID: 125 RVA: 0x00002311 File Offset: 0x00000511
		public unsafe static MatchTargetFields None
		{
			get
			{
				MatchTargetFields matchTargetFields;
				IL2CPP.il2cpp_field_static_get_value(MatchTargetFieldConstants.NativeFieldInfoPtr_None, (void*)(&matchTargetFields));
				return matchTargetFields;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(MatchTargetFieldConstants.NativeFieldInfoPtr_None, (void*)(&value));
			}
		}

		// Token: 0x1700002B RID: 43
		// (get) Token: 0x0600007E RID: 126 RVA: 0x00006024 File Offset: 0x00004224
		// (set) Token: 0x0600007F RID: 127 RVA: 0x0000231F File Offset: 0x0000051F
		public unsafe static MatchTargetFields Position
		{
			get
			{
				MatchTargetFields matchTargetFields;
				IL2CPP.il2cpp_field_static_get_value(MatchTargetFieldConstants.NativeFieldInfoPtr_Position, (void*)(&matchTargetFields));
				return matchTargetFields;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(MatchTargetFieldConstants.NativeFieldInfoPtr_Position, (void*)(&value));
			}
		}

		// Token: 0x1700002C RID: 44
		// (get) Token: 0x06000080 RID: 128 RVA: 0x00006040 File Offset: 0x00004240
		// (set) Token: 0x06000081 RID: 129 RVA: 0x0000232D File Offset: 0x0000052D
		public unsafe static MatchTargetFields Rotation
		{
			get
			{
				MatchTargetFields matchTargetFields;
				IL2CPP.il2cpp_field_static_get_value(MatchTargetFieldConstants.NativeFieldInfoPtr_Rotation, (void*)(&matchTargetFields));
				return matchTargetFields;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(MatchTargetFieldConstants.NativeFieldInfoPtr_Rotation, (void*)(&value));
			}
		}

		// Token: 0x04000066 RID: 102
		private static readonly IntPtr NativeFieldInfoPtr_All;

		// Token: 0x04000067 RID: 103
		private static readonly IntPtr NativeFieldInfoPtr_None;

		// Token: 0x04000068 RID: 104
		private static readonly IntPtr NativeFieldInfoPtr_Position;

		// Token: 0x04000069 RID: 105
		private static readonly IntPtr NativeFieldInfoPtr_Rotation;

		// Token: 0x0400006A RID: 106
		private static readonly IntPtr NativeMethodInfoPtr_HasAny_Public_Static_Boolean_MatchTargetFields_MatchTargetFields_0;

		// Token: 0x0400006B RID: 107
		private static readonly IntPtr NativeMethodInfoPtr_Toggle_Public_Static_MatchTargetFields_MatchTargetFields_MatchTargetFields_0;
	}
}
