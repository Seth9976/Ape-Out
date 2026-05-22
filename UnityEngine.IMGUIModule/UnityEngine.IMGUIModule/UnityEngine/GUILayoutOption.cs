using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;

namespace UnityEngine
{
	// Token: 0x0200000C RID: 12
	public sealed class GUILayoutOption : Object
	{
		// Token: 0x0600026D RID: 621 RVA: 0x0000B604 File Offset: 0x00009804
		// Note: this type is marked as 'beforefieldinit'.
		static GUILayoutOption()
		{
			Il2CppClassPointerStore<GUILayoutOption>.NativeClassPtr = IL2CPP.GetIl2CppClass("UnityEngine.IMGUIModule.dll", "UnityEngine", "GUILayoutOption");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<GUILayoutOption>.NativeClassPtr);
			GUILayoutOption.NativeFieldInfoPtr_type = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GUILayoutOption>.NativeClassPtr, "type");
			GUILayoutOption.NativeFieldInfoPtr_value = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GUILayoutOption>.NativeClassPtr, "value");
			GUILayoutOption.NativeMethodInfoPtr__ctor_Internal_Void_Type_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GUILayoutOption>.NativeClassPtr, 100663470);
		}

		// Token: 0x0600026E RID: 622 RVA: 0x0000B670 File Offset: 0x00009870
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 106068, RefRangeEnd = 106070, XrefRangeStart = 106068, XrefRangeEnd = 106070, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe GUILayoutOption(GUILayoutOption.Type type, Object value)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<GUILayoutOption>.NativeClassPtr))
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref type;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(value);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GUILayoutOption.NativeMethodInfoPtr__ctor_Internal_Void_Type_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600026F RID: 623 RVA: 0x00002F0B File Offset: 0x0000110B
		public GUILayoutOption(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x1700004F RID: 79
		// (get) Token: 0x06000270 RID: 624 RVA: 0x0000B6CC File Offset: 0x000098CC
		// (set) Token: 0x06000271 RID: 625 RVA: 0x00002F14 File Offset: 0x00001114
		public unsafe GUILayoutOption.Type type
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(GUILayoutOption.NativeFieldInfoPtr_type);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(GUILayoutOption.NativeFieldInfoPtr_type)) = value;
			}
		}

		// Token: 0x17000050 RID: 80
		// (get) Token: 0x06000272 RID: 626 RVA: 0x0000B6F4 File Offset: 0x000098F4
		// (set) Token: 0x06000273 RID: 627 RVA: 0x00002F2F File Offset: 0x0000112F
		public unsafe Object value
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(GUILayoutOption.NativeFieldInfoPtr_value);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Object>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(GUILayoutOption.NativeFieldInfoPtr_value), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x04000133 RID: 307
		private static readonly IntPtr NativeFieldInfoPtr_type;

		// Token: 0x04000134 RID: 308
		private static readonly IntPtr NativeFieldInfoPtr_value;

		// Token: 0x04000135 RID: 309
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Internal_Void_Type_Object_0;

		// Token: 0x0200006E RID: 110
		[OriginalName("UnityEngine.IMGUIModule.dll", "", "Type")]
		public enum Type
		{
			// Token: 0x040003CD RID: 973
			fixedWidth,
			// Token: 0x040003CE RID: 974
			fixedHeight,
			// Token: 0x040003CF RID: 975
			minWidth,
			// Token: 0x040003D0 RID: 976
			maxWidth,
			// Token: 0x040003D1 RID: 977
			minHeight,
			// Token: 0x040003D2 RID: 978
			maxHeight,
			// Token: 0x040003D3 RID: 979
			stretchWidth,
			// Token: 0x040003D4 RID: 980
			stretchHeight,
			// Token: 0x040003D5 RID: 981
			alignStart,
			// Token: 0x040003D6 RID: 982
			alignMiddle,
			// Token: 0x040003D7 RID: 983
			alignEnd,
			// Token: 0x040003D8 RID: 984
			alignJustify,
			// Token: 0x040003D9 RID: 985
			equalSize,
			// Token: 0x040003DA RID: 986
			spacing
		}
	}
}
