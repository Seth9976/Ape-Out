using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;
using UnityEngine;

namespace Il2CppTMPro
{
	// Token: 0x02000061 RID: 97
	public class Compute_DT_EventArgs : global::Il2CppSystem.Object
	{
		// Token: 0x06000C1C RID: 3100 RVA: 0x00033500 File Offset: 0x00031700
		// Note: this type is marked as 'beforefieldinit'.
		static Compute_DT_EventArgs()
		{
			Il2CppClassPointerStore<Compute_DT_EventArgs>.NativeClassPtr = IL2CPP.GetIl2CppClass("Unity.TextMeshPro.dll", "TMPro", "Compute_DT_EventArgs");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<Compute_DT_EventArgs>.NativeClassPtr);
			Compute_DT_EventArgs.NativeFieldInfoPtr_EventType = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Compute_DT_EventArgs>.NativeClassPtr, "EventType");
			Compute_DT_EventArgs.NativeFieldInfoPtr_ProgressPercentage = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Compute_DT_EventArgs>.NativeClassPtr, "ProgressPercentage");
			Compute_DT_EventArgs.NativeFieldInfoPtr_Colors = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Compute_DT_EventArgs>.NativeClassPtr, "Colors");
			Compute_DT_EventArgs.NativeMethodInfoPtr__ctor_Public_Void_Compute_DistanceTransform_EventTypes_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Compute_DT_EventArgs>.NativeClassPtr, 100664683);
			Compute_DT_EventArgs.NativeMethodInfoPtr__ctor_Public_Void_Compute_DistanceTransform_EventTypes_Il2CppStructArray_1_Color_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Compute_DT_EventArgs>.NativeClassPtr, 100664684);
		}

		// Token: 0x06000C1D RID: 3101 RVA: 0x00033594 File Offset: 0x00031794
		[CallerCount(0)]
		public unsafe Compute_DT_EventArgs(Compute_DistanceTransform_EventTypes type, float progress)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<Compute_DT_EventArgs>.NativeClassPtr))
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref type;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref progress;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Compute_DT_EventArgs.NativeMethodInfoPtr__ctor_Public_Void_Compute_DistanceTransform_EventTypes_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000C1E RID: 3102 RVA: 0x000335EC File Offset: 0x000317EC
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 106068, RefRangeEnd = 106070, XrefRangeStart = 106068, XrefRangeEnd = 106070, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe Compute_DT_EventArgs(Compute_DistanceTransform_EventTypes type, Il2CppStructArray<Color> colors)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<Compute_DT_EventArgs>.NativeClassPtr))
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref type;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(colors);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Compute_DT_EventArgs.NativeMethodInfoPtr__ctor_Public_Void_Compute_DistanceTransform_EventTypes_Il2CppStructArray_1_Color_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000C1F RID: 3103 RVA: 0x000079ED File Offset: 0x00005BED
		public Compute_DT_EventArgs(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x1700048C RID: 1164
		// (get) Token: 0x06000C20 RID: 3104 RVA: 0x00033648 File Offset: 0x00031848
		// (set) Token: 0x06000C21 RID: 3105 RVA: 0x000079F6 File Offset: 0x00005BF6
		public unsafe Compute_DistanceTransform_EventTypes EventType
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Compute_DT_EventArgs.NativeFieldInfoPtr_EventType);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Compute_DT_EventArgs.NativeFieldInfoPtr_EventType)) = value;
			}
		}

		// Token: 0x1700048D RID: 1165
		// (get) Token: 0x06000C22 RID: 3106 RVA: 0x00033670 File Offset: 0x00031870
		// (set) Token: 0x06000C23 RID: 3107 RVA: 0x00007A11 File Offset: 0x00005C11
		public unsafe float ProgressPercentage
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Compute_DT_EventArgs.NativeFieldInfoPtr_ProgressPercentage);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Compute_DT_EventArgs.NativeFieldInfoPtr_ProgressPercentage)) = value;
			}
		}

		// Token: 0x1700048E RID: 1166
		// (get) Token: 0x06000C24 RID: 3108 RVA: 0x00033698 File Offset: 0x00031898
		// (set) Token: 0x06000C25 RID: 3109 RVA: 0x00007A2C File Offset: 0x00005C2C
		public unsafe Il2CppStructArray<Color> Colors
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Compute_DT_EventArgs.NativeFieldInfoPtr_Colors);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppStructArray<Color>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Compute_DT_EventArgs.NativeFieldInfoPtr_Colors), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x040009AC RID: 2476
		private static readonly IntPtr NativeFieldInfoPtr_EventType;

		// Token: 0x040009AD RID: 2477
		private static readonly IntPtr NativeFieldInfoPtr_ProgressPercentage;

		// Token: 0x040009AE RID: 2478
		private static readonly IntPtr NativeFieldInfoPtr_Colors;

		// Token: 0x040009AF RID: 2479
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Compute_DistanceTransform_EventTypes_Single_0;

		// Token: 0x040009B0 RID: 2480
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Compute_DistanceTransform_EventTypes_Il2CppStructArray_1_Color_0;
	}
}
