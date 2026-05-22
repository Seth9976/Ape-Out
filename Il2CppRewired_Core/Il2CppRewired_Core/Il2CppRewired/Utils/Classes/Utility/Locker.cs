using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;

namespace Il2CppRewired.Utils.Classes.Utility
{
	// Token: 0x020001FE RID: 510
	public sealed class Locker : ValueType
	{
		// Token: 0x060034F1 RID: 13553 RVA: 0x00108348 File Offset: 0x00106548
		// Note: this type is marked as 'beforefieldinit'.
		static Locker()
		{
			Il2CppClassPointerStore<Locker>.NativeClassPtr = IL2CPP.GetIl2CppClass("Rewired_Core.dll", "Rewired.Utils.Classes.Utility", "Locker");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<Locker>.NativeClassPtr);
			Locker.NativeFieldInfoPtr_QOvYBMumHBTKRswPnUjkbLxwisx = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Locker>.NativeClassPtr, "QOvYBMumHBTKRswPnUjkbLxwisx");
			Locker.NativeMethodInfoPtr__ctor_Public_Void_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Locker>.NativeClassPtr, 100676560);
			Locker.NativeMethodInfoPtr_Dispose_Public_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Locker>.NativeClassPtr, 100676561);
		}

		// Token: 0x060034F2 RID: 13554 RVA: 0x001083B4 File Offset: 0x001065B4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 345928, XrefRangeEnd = 345929, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe Locker(Object target)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<Locker>.NativeClassPtr))
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(target);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Locker.NativeMethodInfoPtr__ctor_Public_Void_Object_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(this)), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x060034F3 RID: 13555 RVA: 0x00108404 File Offset: 0x00106604
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 345929, XrefRangeEnd = 345930, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Dispose()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Locker.NativeMethodInfoPtr_Dispose_Public_Virtual_Final_New_Void_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(this)), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060034F4 RID: 13556 RVA: 0x000121A7 File Offset: 0x000103A7
		public Locker(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x060034F5 RID: 13557 RVA: 0x000121B0 File Offset: 0x000103B0
		public Locker()
			: base(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<Locker>.NativeClassPtr))
		{
		}

		// Token: 0x17000FBA RID: 4026
		// (get) Token: 0x060034F6 RID: 13558 RVA: 0x0010843C File Offset: 0x0010663C
		// (set) Token: 0x060034F7 RID: 13559 RVA: 0x000121C2 File Offset: 0x000103C2
		public unsafe Object QOvYBMumHBTKRswPnUjkbLxwisx
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Locker.NativeFieldInfoPtr_QOvYBMumHBTKRswPnUjkbLxwisx);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Object>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Locker.NativeFieldInfoPtr_QOvYBMumHBTKRswPnUjkbLxwisx), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x04002D27 RID: 11559
		private static readonly IntPtr NativeFieldInfoPtr_QOvYBMumHBTKRswPnUjkbLxwisx;

		// Token: 0x04002D28 RID: 11560
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Object_0;

		// Token: 0x04002D29 RID: 11561
		private static readonly IntPtr NativeMethodInfoPtr_Dispose_Public_Virtual_Final_New_Void_0;
	}
}
