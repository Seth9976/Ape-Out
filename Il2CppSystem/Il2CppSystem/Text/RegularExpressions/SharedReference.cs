using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;

namespace Il2CppSystem.Text.RegularExpressions
{
	// Token: 0x0200004F RID: 79
	public sealed class SharedReference : Object
	{
		// Token: 0x060004AF RID: 1199 RVA: 0x00022FE8 File Offset: 0x000211E8
		// Note: this type is marked as 'beforefieldinit'.
		static SharedReference()
		{
			Il2CppClassPointerStore<SharedReference>.NativeClassPtr = IL2CPP.GetIl2CppClass("System.dll", "System.Text.RegularExpressions", "SharedReference");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<SharedReference>.NativeClassPtr);
			SharedReference.NativeFieldInfoPtr__ref = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SharedReference>.NativeClassPtr, "_ref");
			SharedReference.NativeFieldInfoPtr__locked = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SharedReference>.NativeClassPtr, "_locked");
			SharedReference.NativeMethodInfoPtr_Get_Internal_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SharedReference>.NativeClassPtr, 100664065);
			SharedReference.NativeMethodInfoPtr_Cache_Internal_Void_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SharedReference>.NativeClassPtr, 100664066);
			SharedReference.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SharedReference>.NativeClassPtr, 100664067);
		}

		// Token: 0x060004B0 RID: 1200 RVA: 0x0002307C File Offset: 0x0002127C
		[CallerCount(0)]
		public unsafe Object Get()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SharedReference.NativeMethodInfoPtr_Get_Internal_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<Object>(intPtr3) : null;
		}

		// Token: 0x060004B1 RID: 1201 RVA: 0x000230BC File Offset: 0x000212BC
		[CallerCount(0)]
		public unsafe void Cache(Object obj)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(obj);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SharedReference.NativeMethodInfoPtr_Cache_Internal_Void_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x060004B2 RID: 1202 RVA: 0x00023100 File Offset: 0x00021300
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 369953, XrefRangeEnd = 369957, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe SharedReference()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<SharedReference>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SharedReference.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060004B3 RID: 1203 RVA: 0x00003B30 File Offset: 0x00001D30
		public SharedReference(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x1700016E RID: 366
		// (get) Token: 0x060004B4 RID: 1204 RVA: 0x0002313C File Offset: 0x0002133C
		// (set) Token: 0x060004B5 RID: 1205 RVA: 0x00003B39 File Offset: 0x00001D39
		public unsafe WeakReference _ref
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SharedReference.NativeFieldInfoPtr__ref);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<WeakReference>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(SharedReference.NativeFieldInfoPtr__ref), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700016F RID: 367
		// (get) Token: 0x060004B6 RID: 1206 RVA: 0x0002316C File Offset: 0x0002136C
		// (set) Token: 0x060004B7 RID: 1207 RVA: 0x00003B58 File Offset: 0x00001D58
		public unsafe int _locked
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SharedReference.NativeFieldInfoPtr__locked);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SharedReference.NativeFieldInfoPtr__locked)) = value;
			}
		}

		// Token: 0x040003A1 RID: 929
		private static readonly IntPtr NativeFieldInfoPtr__ref;

		// Token: 0x040003A2 RID: 930
		private static readonly IntPtr NativeFieldInfoPtr__locked;

		// Token: 0x040003A3 RID: 931
		private static readonly IntPtr NativeMethodInfoPtr_Get_Internal_Object_0;

		// Token: 0x040003A4 RID: 932
		private static readonly IntPtr NativeMethodInfoPtr_Cache_Internal_Void_Object_0;

		// Token: 0x040003A5 RID: 933
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
	}
}
