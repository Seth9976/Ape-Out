using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;

namespace Il2CppSystem.Collections
{
	// Token: 0x0200046E RID: 1134
	public sealed class LowLevelComparer : Object
	{
		// Token: 0x060044D8 RID: 17624 RVA: 0x0013CC30 File Offset: 0x0013AE30
		// Note: this type is marked as 'beforefieldinit'.
		static LowLevelComparer()
		{
			Il2CppClassPointerStore<LowLevelComparer>.NativeClassPtr = IL2CPP.GetIl2CppClass("mscorlib.dll", "System.Collections", "LowLevelComparer");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<LowLevelComparer>.NativeClassPtr);
			LowLevelComparer.NativeFieldInfoPtr_Default = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LowLevelComparer>.NativeClassPtr, "Default");
			LowLevelComparer.NativeMethodInfoPtr__ctor_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LowLevelComparer>.NativeClassPtr, 100673304);
			LowLevelComparer.NativeMethodInfoPtr_Compare_Public_Virtual_Final_New_Int32_Object_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LowLevelComparer>.NativeClassPtr, 100673305);
		}

		// Token: 0x060044D9 RID: 17625 RVA: 0x0013CC9C File Offset: 0x0013AE9C
		[CallerCount(7)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 7, XrefRangeStart = 0, XrefRangeEnd = 7, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe LowLevelComparer()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<LowLevelComparer>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LowLevelComparer.NativeMethodInfoPtr__ctor_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060044DA RID: 17626 RVA: 0x0013CCD8 File Offset: 0x0013AED8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 228080, XrefRangeEnd = 228087, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe int Compare(Object a, Object b)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(a);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(b);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LowLevelComparer.NativeMethodInfoPtr_Compare_Public_Virtual_Final_New_Int32_Object_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x060044DB RID: 17627 RVA: 0x0001A46B File Offset: 0x0001866B
		public LowLevelComparer(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x17001180 RID: 4480
		// (get) Token: 0x060044DC RID: 17628 RVA: 0x0013CD38 File Offset: 0x0013AF38
		// (set) Token: 0x060044DD RID: 17629 RVA: 0x0001A474 File Offset: 0x00018674
		public unsafe static LowLevelComparer Default
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(LowLevelComparer.NativeFieldInfoPtr_Default, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<LowLevelComparer>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(LowLevelComparer.NativeFieldInfoPtr_Default, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x0400380D RID: 14349
		private static readonly IntPtr NativeFieldInfoPtr_Default;

		// Token: 0x0400380E RID: 14350
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Private_Void_0;

		// Token: 0x0400380F RID: 14351
		private static readonly IntPtr NativeMethodInfoPtr_Compare_Public_Virtual_Final_New_Int32_Object_Object_0;
	}
}
