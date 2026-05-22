using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppSystem;

namespace UnityEngine.Timeline
{
	// Token: 0x02000043 RID: 67
	public class CustomStyleAttribute : Attribute
	{
		// Token: 0x060004B1 RID: 1201 RVA: 0x00016DE0 File Offset: 0x00014FE0
		// Note: this type is marked as 'beforefieldinit'.
		static CustomStyleAttribute()
		{
			Il2CppClassPointerStore<CustomStyleAttribute>.NativeClassPtr = IL2CPP.GetIl2CppClass("Unity.Timeline.dll", "UnityEngine.Timeline", "CustomStyleAttribute");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<CustomStyleAttribute>.NativeClassPtr);
			CustomStyleAttribute.NativeFieldInfoPtr_ussStyle = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CustomStyleAttribute>.NativeClassPtr, "ussStyle");
			CustomStyleAttribute.NativeMethodInfoPtr__ctor_Public_Void_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CustomStyleAttribute>.NativeClassPtr, 100664073);
		}

		// Token: 0x060004B2 RID: 1202 RVA: 0x00016E38 File Offset: 0x00015038
		[CallerCount(79)]
		[CachedScanResults(RefRangeStart = 14237, RefRangeEnd = 14316, XrefRangeStart = 14237, XrefRangeEnd = 14316, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe CustomStyleAttribute(string ussStyle)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<CustomStyleAttribute>.NativeClassPtr))
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(ussStyle);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CustomStyleAttribute.NativeMethodInfoPtr__ctor_Public_Void_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x060004B3 RID: 1203 RVA: 0x000038AF File Offset: 0x00001AAF
		public CustomStyleAttribute(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x17000182 RID: 386
		// (get) Token: 0x060004B4 RID: 1204 RVA: 0x00016E84 File Offset: 0x00015084
		// (set) Token: 0x060004B5 RID: 1205 RVA: 0x000038B8 File Offset: 0x00001AB8
		public unsafe string ussStyle
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CustomStyleAttribute.NativeFieldInfoPtr_ussStyle);
				return IL2CPP.Il2CppStringToManaged(*intPtr);
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(CustomStyleAttribute.NativeFieldInfoPtr_ussStyle), IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x040003A2 RID: 930
		private static readonly IntPtr NativeFieldInfoPtr_ussStyle;

		// Token: 0x040003A3 RID: 931
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_String_0;
	}
}
