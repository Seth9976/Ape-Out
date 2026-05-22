using System;
using System.Runtime.InteropServices;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;

namespace Il2CppSystem.Runtime.InteropServices
{
	// Token: 0x02000459 RID: 1113
	[StructLayout(2)]
	public struct GCHandle
	{
		// Token: 0x06004440 RID: 17472 RVA: 0x0013AA80 File Offset: 0x00138C80
		// Note: this type is marked as 'beforefieldinit'.
		static GCHandle()
		{
			Il2CppClassPointerStore<GCHandle>.NativeClassPtr = IL2CPP.GetIl2CppClass("mscorlib.dll", "System.Runtime.InteropServices", "GCHandle");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<GCHandle>.NativeClassPtr);
			GCHandle.NativeFieldInfoPtr_handle = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GCHandle>.NativeClassPtr, "handle");
			GCHandle.NativeMethodInfoPtr__ctor_Private_Void_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GCHandle>.NativeClassPtr, 100673222);
			GCHandle.NativeMethodInfoPtr__ctor_Internal_Void_Object_GCHandleType_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GCHandle>.NativeClassPtr, 100673223);
			GCHandle.NativeMethodInfoPtr_get_IsAllocated_Public_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GCHandle>.NativeClassPtr, 100673224);
			GCHandle.NativeMethodInfoPtr_get_Target_Public_get_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GCHandle>.NativeClassPtr, 100673225);
			GCHandle.NativeMethodInfoPtr_set_Target_Public_set_Void_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GCHandle>.NativeClassPtr, 100673226);
			GCHandle.NativeMethodInfoPtr_AddrOfPinnedObject_Public_IntPtr_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GCHandle>.NativeClassPtr, 100673227);
			GCHandle.NativeMethodInfoPtr_Alloc_Public_Static_GCHandle_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GCHandle>.NativeClassPtr, 100673228);
			GCHandle.NativeMethodInfoPtr_Alloc_Public_Static_GCHandle_Object_GCHandleType_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GCHandle>.NativeClassPtr, 100673229);
			GCHandle.NativeMethodInfoPtr_Free_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GCHandle>.NativeClassPtr, 100673230);
			GCHandle.NativeMethodInfoPtr_op_Explicit_Public_Static_IntPtr_GCHandle_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GCHandle>.NativeClassPtr, 100673231);
			GCHandle.NativeMethodInfoPtr_op_Explicit_Public_Static_GCHandle_IntPtr_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GCHandle>.NativeClassPtr, 100673232);
			GCHandle.NativeMethodInfoPtr_CheckCurrentDomain_Private_Static_Boolean_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GCHandle>.NativeClassPtr, 100673233);
			GCHandle.NativeMethodInfoPtr_GetTarget_Private_Static_Object_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GCHandle>.NativeClassPtr, 100673234);
			GCHandle.NativeMethodInfoPtr_GetTargetHandle_Private_Static_Int32_Object_Int32_GCHandleType_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GCHandle>.NativeClassPtr, 100673235);
			GCHandle.NativeMethodInfoPtr_FreeHandle_Private_Static_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GCHandle>.NativeClassPtr, 100673236);
			GCHandle.NativeMethodInfoPtr_GetAddrOfPinnedObject_Private_Static_IntPtr_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GCHandle>.NativeClassPtr, 100673237);
			GCHandle.NativeMethodInfoPtr_op_Equality_Public_Static_Boolean_GCHandle_GCHandle_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GCHandle>.NativeClassPtr, 100673238);
			GCHandle.NativeMethodInfoPtr_Equals_Public_Virtual_Boolean_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GCHandle>.NativeClassPtr, 100673239);
			GCHandle.NativeMethodInfoPtr_GetHashCode_Public_Virtual_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GCHandle>.NativeClassPtr, 100673240);
			GCHandle.NativeMethodInfoPtr_FromIntPtr_Public_Static_GCHandle_IntPtr_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GCHandle>.NativeClassPtr, 100673241);
			GCHandle.NativeMethodInfoPtr_ToIntPtr_Public_Static_IntPtr_GCHandle_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GCHandle>.NativeClassPtr, 100673242);
		}

		// Token: 0x06004441 RID: 17473 RVA: 0x0013AC68 File Offset: 0x00138E68
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 227587, XrefRangeEnd = 227588, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe GCHandle(Object obj)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(obj);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GCHandle.NativeMethodInfoPtr__ctor_Private_Void_Object_0, ref this, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06004442 RID: 17474 RVA: 0x0013ACA0 File Offset: 0x00138EA0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 227588, XrefRangeEnd = 227589, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe GCHandle(Object value, GCHandleType type)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref type;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GCHandle.NativeMethodInfoPtr__ctor_Internal_Void_Object_GCHandleType_0, ref this, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x1700116D RID: 4461
		// (get) Token: 0x06004443 RID: 17475 RVA: 0x0013ACE4 File Offset: 0x00138EE4
		public unsafe bool IsAllocated
		{
			[CallerCount(0)]
			get
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GCHandle.NativeMethodInfoPtr_get_IsAllocated_Public_get_Boolean_0, ref this, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x1700116E RID: 4462
		// (get) Token: 0x06004444 RID: 17476 RVA: 0x0013AD14 File Offset: 0x00138F14
		// (set) Token: 0x06004445 RID: 17477 RVA: 0x0013AD48 File Offset: 0x00138F48
		public unsafe Object Target
		{
			[CallerCount(1)]
			[CachedScanResults(RefRangeStart = 227597, RefRangeEnd = 227598, XrefRangeStart = 227589, XrefRangeEnd = 227597, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GCHandle.NativeMethodInfoPtr_get_Target_Public_get_Object_0, ref this, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Object>(intPtr3) : null;
			}
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 227598, XrefRangeEnd = 227599, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GCHandle.NativeMethodInfoPtr_set_Target_Public_set_Void_Object_0, ref this, (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x06004446 RID: 17478 RVA: 0x0013AD80 File Offset: 0x00138F80
		[CallerCount(31)]
		[CachedScanResults(RefRangeStart = 227600, RefRangeEnd = 227631, XrefRangeStart = 227599, XrefRangeEnd = 227600, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe IntPtr AddrOfPinnedObject()
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GCHandle.NativeMethodInfoPtr_AddrOfPinnedObject_Public_IntPtr_0, ref this, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06004447 RID: 17479 RVA: 0x0013ADB0 File Offset: 0x00138FB0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 227631, XrefRangeEnd = 227632, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static GCHandle Alloc(Object value)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GCHandle.NativeMethodInfoPtr_Alloc_Public_Static_GCHandle_Object_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06004448 RID: 17480 RVA: 0x0013ADF4 File Offset: 0x00138FF4
		[CallerCount(3)]
		[CachedScanResults(RefRangeStart = 227635, RefRangeEnd = 227638, XrefRangeStart = 227632, XrefRangeEnd = 227635, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static GCHandle Alloc(Object value, GCHandleType type)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref type;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GCHandle.NativeMethodInfoPtr_Alloc_Public_Static_GCHandle_Object_GCHandleType_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06004449 RID: 17481 RVA: 0x0013AE44 File Offset: 0x00139044
		[CallerCount(15)]
		[CachedScanResults(RefRangeStart = 227645, RefRangeEnd = 227660, XrefRangeStart = 227638, XrefRangeEnd = 227645, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Free()
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GCHandle.NativeMethodInfoPtr_Free_Public_Void_0, ref this, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600444A RID: 17482 RVA: 0x0013AE6C File Offset: 0x0013906C
		[CallerCount(0)]
		public unsafe static explicit operator IntPtr(GCHandle value)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref value;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GCHandle.NativeMethodInfoPtr_op_Explicit_Public_Static_IntPtr_GCHandle_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x0600444B RID: 17483 RVA: 0x0013AEAC File Offset: 0x001390AC
		[CallerCount(9)]
		[CachedScanResults(RefRangeStart = 227661, RefRangeEnd = 227670, XrefRangeStart = 227660, XrefRangeEnd = 227661, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static explicit operator GCHandle(IntPtr value)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref value;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GCHandle.NativeMethodInfoPtr_op_Explicit_Public_Static_GCHandle_IntPtr_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x0600444C RID: 17484 RVA: 0x0013AEEC File Offset: 0x001390EC
		[CallerCount(0)]
		public unsafe static bool CheckCurrentDomain(int handle)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref handle;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GCHandle.NativeMethodInfoPtr_CheckCurrentDomain_Private_Static_Boolean_Int32_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x0600444D RID: 17485 RVA: 0x0013AF2C File Offset: 0x0013912C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 227670, XrefRangeEnd = 227671, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static Object GetTarget(int handle)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref handle;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GCHandle.NativeMethodInfoPtr_GetTarget_Private_Static_Object_Int32_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Object>(intPtr3) : null;
			}
		}

		// Token: 0x0600444E RID: 17486 RVA: 0x0013AF6C File Offset: 0x0013916C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 227671, XrefRangeEnd = 227676, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static int GetTargetHandle(Object obj, int handle, GCHandleType type)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(obj);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref handle;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref type;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GCHandle.NativeMethodInfoPtr_GetTargetHandle_Private_Static_Int32_Object_Int32_GCHandleType_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x0600444F RID: 17487 RVA: 0x0013AFCC File Offset: 0x001391CC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 227676, XrefRangeEnd = 227677, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void FreeHandle(int handle)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref handle;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GCHandle.NativeMethodInfoPtr_FreeHandle_Private_Static_Void_Int32_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06004450 RID: 17488 RVA: 0x0013B000 File Offset: 0x00139200
		[CallerCount(0)]
		public unsafe static IntPtr GetAddrOfPinnedObject(int handle)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref handle;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GCHandle.NativeMethodInfoPtr_GetAddrOfPinnedObject_Private_Static_IntPtr_Int32_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06004451 RID: 17489 RVA: 0x0013B040 File Offset: 0x00139240
		[CallerCount(0)]
		public unsafe static bool operator ==(GCHandle a, GCHandle b)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref a;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref b;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GCHandle.NativeMethodInfoPtr_op_Equality_Public_Static_Boolean_GCHandle_GCHandle_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06004452 RID: 17490 RVA: 0x0013B08C File Offset: 0x0013928C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 227677, XrefRangeEnd = 227679, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override bool Equals(Object o)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(o);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GCHandle.NativeMethodInfoPtr_Equals_Public_Virtual_Boolean_Object_0, ref this, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06004453 RID: 17491 RVA: 0x0013B0D0 File Offset: 0x001392D0
		[CallerCount(0)]
		public unsafe override int GetHashCode()
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GCHandle.NativeMethodInfoPtr_GetHashCode_Public_Virtual_Int32_0, ref this, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06004454 RID: 17492 RVA: 0x0013B100 File Offset: 0x00139300
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 227679, XrefRangeEnd = 227680, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static GCHandle FromIntPtr(IntPtr value)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref value;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GCHandle.NativeMethodInfoPtr_FromIntPtr_Public_Static_GCHandle_IntPtr_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06004455 RID: 17493 RVA: 0x0013B140 File Offset: 0x00139340
		[CallerCount(0)]
		public unsafe static IntPtr ToIntPtr(GCHandle value)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref value;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GCHandle.NativeMethodInfoPtr_ToIntPtr_Public_Static_IntPtr_GCHandle_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06004456 RID: 17494 RVA: 0x0001A074 File Offset: 0x00018274
		public Object BoxIl2CppObject()
		{
			return new Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<GCHandle>.NativeClassPtr, ref this));
		}

		// Token: 0x040037A6 RID: 14246
		private static readonly IntPtr NativeFieldInfoPtr_handle;

		// Token: 0x040037A7 RID: 14247
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Private_Void_Object_0;

		// Token: 0x040037A8 RID: 14248
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Internal_Void_Object_GCHandleType_0;

		// Token: 0x040037A9 RID: 14249
		private static readonly IntPtr NativeMethodInfoPtr_get_IsAllocated_Public_get_Boolean_0;

		// Token: 0x040037AA RID: 14250
		private static readonly IntPtr NativeMethodInfoPtr_get_Target_Public_get_Object_0;

		// Token: 0x040037AB RID: 14251
		private static readonly IntPtr NativeMethodInfoPtr_set_Target_Public_set_Void_Object_0;

		// Token: 0x040037AC RID: 14252
		private static readonly IntPtr NativeMethodInfoPtr_AddrOfPinnedObject_Public_IntPtr_0;

		// Token: 0x040037AD RID: 14253
		private static readonly IntPtr NativeMethodInfoPtr_Alloc_Public_Static_GCHandle_Object_0;

		// Token: 0x040037AE RID: 14254
		private static readonly IntPtr NativeMethodInfoPtr_Alloc_Public_Static_GCHandle_Object_GCHandleType_0;

		// Token: 0x040037AF RID: 14255
		private static readonly IntPtr NativeMethodInfoPtr_Free_Public_Void_0;

		// Token: 0x040037B0 RID: 14256
		private static readonly IntPtr NativeMethodInfoPtr_op_Explicit_Public_Static_IntPtr_GCHandle_0;

		// Token: 0x040037B1 RID: 14257
		private static readonly IntPtr NativeMethodInfoPtr_op_Explicit_Public_Static_GCHandle_IntPtr_0;

		// Token: 0x040037B2 RID: 14258
		private static readonly IntPtr NativeMethodInfoPtr_CheckCurrentDomain_Private_Static_Boolean_Int32_0;

		// Token: 0x040037B3 RID: 14259
		private static readonly IntPtr NativeMethodInfoPtr_GetTarget_Private_Static_Object_Int32_0;

		// Token: 0x040037B4 RID: 14260
		private static readonly IntPtr NativeMethodInfoPtr_GetTargetHandle_Private_Static_Int32_Object_Int32_GCHandleType_0;

		// Token: 0x040037B5 RID: 14261
		private static readonly IntPtr NativeMethodInfoPtr_FreeHandle_Private_Static_Void_Int32_0;

		// Token: 0x040037B6 RID: 14262
		private static readonly IntPtr NativeMethodInfoPtr_GetAddrOfPinnedObject_Private_Static_IntPtr_Int32_0;

		// Token: 0x040037B7 RID: 14263
		private static readonly IntPtr NativeMethodInfoPtr_op_Equality_Public_Static_Boolean_GCHandle_GCHandle_0;

		// Token: 0x040037B8 RID: 14264
		private static readonly IntPtr NativeMethodInfoPtr_Equals_Public_Virtual_Boolean_Object_0;

		// Token: 0x040037B9 RID: 14265
		private static readonly IntPtr NativeMethodInfoPtr_GetHashCode_Public_Virtual_Int32_0;

		// Token: 0x040037BA RID: 14266
		private static readonly IntPtr NativeMethodInfoPtr_FromIntPtr_Public_Static_GCHandle_IntPtr_0;

		// Token: 0x040037BB RID: 14267
		private static readonly IntPtr NativeMethodInfoPtr_ToIntPtr_Public_Static_IntPtr_GCHandle_0;

		// Token: 0x040037BC RID: 14268
		[FieldOffset(0)]
		public int handle;
	}
}
