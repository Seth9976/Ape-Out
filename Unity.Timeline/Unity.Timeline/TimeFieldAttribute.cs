using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;

namespace UnityEngine.Timeline
{
	// Token: 0x02000041 RID: 65
	public class TimeFieldAttribute : PropertyAttribute
	{
		// Token: 0x060004A8 RID: 1192 RVA: 0x00016C8C File Offset: 0x00014E8C
		// Note: this type is marked as 'beforefieldinit'.
		static TimeFieldAttribute()
		{
			Il2CppClassPointerStore<TimeFieldAttribute>.NativeClassPtr = IL2CPP.GetIl2CppClass("Unity.Timeline.dll", "UnityEngine.Timeline", "TimeFieldAttribute");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<TimeFieldAttribute>.NativeClassPtr);
			TimeFieldAttribute.NativeFieldInfoPtr__useEditMode_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TimeFieldAttribute>.NativeClassPtr, "<useEditMode>k__BackingField");
			TimeFieldAttribute.NativeMethodInfoPtr_get_useEditMode_Public_get_UseEditMode_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TimeFieldAttribute>.NativeClassPtr, 100664070);
			TimeFieldAttribute.NativeMethodInfoPtr__ctor_Public_Void_UseEditMode_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TimeFieldAttribute>.NativeClassPtr, 100664071);
		}

		// Token: 0x17000181 RID: 385
		// (get) Token: 0x060004A9 RID: 1193 RVA: 0x00016CF8 File Offset: 0x00014EF8
		public unsafe TimeFieldAttribute.UseEditMode useEditMode
		{
			[CallerCount(1)]
			[CachedScanResults(RefRangeStart = 896, RefRangeEnd = 897, XrefRangeStart = 896, XrefRangeEnd = 897, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TimeFieldAttribute.NativeMethodInfoPtr_get_useEditMode_Public_get_UseEditMode_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x060004AA RID: 1194 RVA: 0x00016D34 File Offset: 0x00014F34
		[CallerCount(0)]
		public unsafe TimeFieldAttribute(TimeFieldAttribute.UseEditMode useEditMode = TimeFieldAttribute.UseEditMode.ApplyEditMode)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<TimeFieldAttribute>.NativeClassPtr))
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref useEditMode;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TimeFieldAttribute.NativeMethodInfoPtr__ctor_Public_Void_UseEditMode_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x060004AB RID: 1195 RVA: 0x00003849 File Offset: 0x00001A49
		public TimeFieldAttribute(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x17000180 RID: 384
		// (get) Token: 0x060004AC RID: 1196 RVA: 0x00016D7C File Offset: 0x00014F7C
		// (set) Token: 0x060004AD RID: 1197 RVA: 0x00003852 File Offset: 0x00001A52
		public unsafe TimeFieldAttribute.UseEditMode _useEditMode_k__BackingField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TimeFieldAttribute.NativeFieldInfoPtr__useEditMode_k__BackingField);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TimeFieldAttribute.NativeFieldInfoPtr__useEditMode_k__BackingField)) = value;
			}
		}

		// Token: 0x0400039E RID: 926
		private static readonly IntPtr NativeFieldInfoPtr__useEditMode_k__BackingField;

		// Token: 0x0400039F RID: 927
		private static readonly IntPtr NativeMethodInfoPtr_get_useEditMode_Public_get_UseEditMode_0;

		// Token: 0x040003A0 RID: 928
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_UseEditMode_0;

		// Token: 0x02000077 RID: 119
		[OriginalName("Unity.Timeline.dll", "", "UseEditMode")]
		public enum UseEditMode
		{
			// Token: 0x040004BA RID: 1210
			None,
			// Token: 0x040004BB RID: 1211
			ApplyEditMode
		}
	}
}
