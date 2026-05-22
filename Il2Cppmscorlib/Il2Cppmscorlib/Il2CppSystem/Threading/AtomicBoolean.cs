using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;

namespace Il2CppSystem.Threading
{
	// Token: 0x02000259 RID: 601
	public class AtomicBoolean : Object
	{
		// Token: 0x060029F1 RID: 10737 RVA: 0x000DC4E0 File Offset: 0x000DA6E0
		// Note: this type is marked as 'beforefieldinit'.
		static AtomicBoolean()
		{
			Il2CppClassPointerStore<AtomicBoolean>.NativeClassPtr = IL2CPP.GetIl2CppClass("mscorlib.dll", "System.Threading", "AtomicBoolean");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<AtomicBoolean>.NativeClassPtr);
			AtomicBoolean.NativeFieldInfoPtr_flag = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AtomicBoolean>.NativeClassPtr, "flag");
			AtomicBoolean.NativeMethodInfoPtr_TryRelaxedSet_Public_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AtomicBoolean>.NativeClassPtr, 100670078);
			AtomicBoolean.NativeMethodInfoPtr_Exchange_Public_Boolean_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AtomicBoolean>.NativeClassPtr, 100670079);
			AtomicBoolean.NativeMethodInfoPtr_Equals_Public_Boolean_AtomicBoolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AtomicBoolean>.NativeClassPtr, 100670080);
			AtomicBoolean.NativeMethodInfoPtr_Equals_Public_Virtual_Boolean_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AtomicBoolean>.NativeClassPtr, 100670081);
			AtomicBoolean.NativeMethodInfoPtr_GetHashCode_Public_Virtual_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AtomicBoolean>.NativeClassPtr, 100670082);
			AtomicBoolean.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AtomicBoolean>.NativeClassPtr, 100670083);
		}

		// Token: 0x060029F2 RID: 10738 RVA: 0x000DC59C File Offset: 0x000DA79C
		[CallerCount(0)]
		public unsafe bool TryRelaxedSet()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AtomicBoolean.NativeMethodInfoPtr_TryRelaxedSet_Public_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x060029F3 RID: 10739 RVA: 0x000DC5D8 File Offset: 0x000DA7D8
		[CallerCount(0)]
		public unsafe bool Exchange(bool newVal)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref newVal;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AtomicBoolean.NativeMethodInfoPtr_Exchange_Public_Boolean_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x060029F4 RID: 10740 RVA: 0x000DC624 File Offset: 0x000DA824
		[CallerCount(0)]
		public unsafe bool Equals(AtomicBoolean rhs)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(rhs);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AtomicBoolean.NativeMethodInfoPtr_Equals_Public_Boolean_AtomicBoolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x060029F5 RID: 10741 RVA: 0x000DC674 File Offset: 0x000DA874
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 200135, XrefRangeEnd = 200137, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override bool Equals(Object rhs)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(rhs);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), AtomicBoolean.NativeMethodInfoPtr_Equals_Public_Virtual_Boolean_Object_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x060029F6 RID: 10742 RVA: 0x000DC6CC File Offset: 0x000DA8CC
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 896, RefRangeEnd = 897, XrefRangeStart = 896, XrefRangeEnd = 897, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override int GetHashCode()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), AtomicBoolean.NativeMethodInfoPtr_GetHashCode_Public_Virtual_Int32_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x060029F7 RID: 10743 RVA: 0x000DC714 File Offset: 0x000DA914
		[CallerCount(7)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 7, XrefRangeStart = 0, XrefRangeEnd = 7, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe AtomicBoolean()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<AtomicBoolean>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AtomicBoolean.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060029F8 RID: 10744 RVA: 0x0000E713 File Offset: 0x0000C913
		public AtomicBoolean(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x170009CF RID: 2511
		// (get) Token: 0x060029F9 RID: 10745 RVA: 0x000DC750 File Offset: 0x000DA950
		// (set) Token: 0x060029FA RID: 10746 RVA: 0x0000E71C File Offset: 0x0000C91C
		public unsafe int flag
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AtomicBoolean.NativeFieldInfoPtr_flag);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AtomicBoolean.NativeFieldInfoPtr_flag)) = value;
			}
		}

		// Token: 0x04002503 RID: 9475
		private static readonly IntPtr NativeFieldInfoPtr_flag;

		// Token: 0x04002504 RID: 9476
		private static readonly IntPtr NativeMethodInfoPtr_TryRelaxedSet_Public_Boolean_0;

		// Token: 0x04002505 RID: 9477
		private static readonly IntPtr NativeMethodInfoPtr_Exchange_Public_Boolean_Boolean_0;

		// Token: 0x04002506 RID: 9478
		private static readonly IntPtr NativeMethodInfoPtr_Equals_Public_Boolean_AtomicBoolean_0;

		// Token: 0x04002507 RID: 9479
		private static readonly IntPtr NativeMethodInfoPtr_Equals_Public_Virtual_Boolean_Object_0;

		// Token: 0x04002508 RID: 9480
		private static readonly IntPtr NativeMethodInfoPtr_GetHashCode_Public_Virtual_Int32_0;

		// Token: 0x04002509 RID: 9481
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
	}
}
