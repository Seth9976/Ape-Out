using System;
using System.Runtime.InteropServices;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppSystem;
using Il2CppSystem.Collections.Generic;
using Unity.Collections;
using Unity.Collections.LowLevel.Unsafe;

namespace UnityEngine
{
	// Token: 0x02000099 RID: 153
	[Serializable]
	[StructLayout(2)]
	public struct Hash128
	{
		// Token: 0x06000E3F RID: 3647 RVA: 0x0003ACB0 File Offset: 0x00038EB0
		// Note: this type is marked as 'beforefieldinit'.
		static Hash128()
		{
			Il2CppClassPointerStore<Hash128>.NativeClassPtr = IL2CPP.GetIl2CppClass("UnityEngine.CoreModule.dll", "UnityEngine", "Hash128");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<Hash128>.NativeClassPtr);
			Hash128.NativeFieldInfoPtr_u64_0 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Hash128>.NativeClassPtr, "u64_0");
			Hash128.NativeFieldInfoPtr_u64_1 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Hash128>.NativeClassPtr, "u64_1");
			Hash128.NativeMethodInfoPtr__ctor_Public_Void_UInt64_UInt64_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Hash128>.NativeClassPtr, 100664331);
			Hash128.NativeMethodInfoPtr_CompareTo_Public_Virtual_Final_New_Int32_Hash128_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Hash128>.NativeClassPtr, 100664332);
			Hash128.NativeMethodInfoPtr_ToString_Public_Virtual_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Hash128>.NativeClassPtr, 100664333);
			Hash128.NativeMethodInfoPtr_Hash128ToStringImpl_Private_Static_String_Hash128_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Hash128>.NativeClassPtr, 100664334);
			Hash128.NativeMethodInfoPtr_Equals_Public_Virtual_Boolean_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Hash128>.NativeClassPtr, 100664335);
			Hash128.NativeMethodInfoPtr_Equals_Public_Virtual_Final_New_Boolean_Hash128_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Hash128>.NativeClassPtr, 100664336);
			Hash128.NativeMethodInfoPtr_GetHashCode_Public_Virtual_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Hash128>.NativeClassPtr, 100664337);
			Hash128.NativeMethodInfoPtr_CompareTo_Public_Virtual_Final_New_Int32_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Hash128>.NativeClassPtr, 100664338);
			Hash128.NativeMethodInfoPtr_op_Equality_Public_Static_Boolean_Hash128_Hash128_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Hash128>.NativeClassPtr, 100664339);
			Hash128.NativeMethodInfoPtr_op_LessThan_Public_Static_Boolean_Hash128_Hash128_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Hash128>.NativeClassPtr, 100664340);
			Hash128.NativeMethodInfoPtr_op_GreaterThan_Public_Static_Boolean_Hash128_Hash128_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Hash128>.NativeClassPtr, 100664341);
			Hash128.NativeMethodInfoPtr_Hash128ToStringImpl_Injected_Private_Static_String_byref_Hash128_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Hash128>.NativeClassPtr, 100664342);
			Hash128.ComputeFromStringDelegateField = IL2CPP.ResolveICall<Hash128.ComputeFromStringDelegate>("UnityEngine.Hash128::ComputeFromString");
			Hash128.ComputeFromPtrDelegateField = IL2CPP.ResolveICall<Hash128.ComputeFromPtrDelegate>("UnityEngine.Hash128::ComputeFromPtr");
			Hash128.ComputeFromArrayDelegateField = IL2CPP.ResolveICall<Hash128.ComputeFromArrayDelegate>("UnityEngine.Hash128::ComputeFromArray");
			Hash128.Parse_InjectedDelegateField = IL2CPP.ResolveICall<Hash128.Parse_InjectedDelegate>("UnityEngine.Hash128::Parse_Injected");
		}

		// Token: 0x06000E40 RID: 3648 RVA: 0x0003AE34 File Offset: 0x00039034
		[CallerCount(0)]
		public unsafe Hash128(ulong u64_0, ulong u64_1)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref u64_0;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref u64_1;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Hash128.NativeMethodInfoPtr__ctor_Public_Void_UInt64_UInt64_0, ref this, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000E41 RID: 3649 RVA: 0x0003AE74 File Offset: 0x00039074
		[CallerCount(0)]
		public unsafe int CompareTo(Hash128 rhs)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref rhs;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Hash128.NativeMethodInfoPtr_CompareTo_Public_Virtual_Final_New_Int32_Hash128_0, ref this, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06000E42 RID: 3650 RVA: 0x0003AEB4 File Offset: 0x000390B4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 491366, XrefRangeEnd = 491368, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override string ToString()
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Hash128.NativeMethodInfoPtr_ToString_Public_Virtual_String_0, ref this, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return IL2CPP.Il2CppStringToManaged(intPtr);
		}

		// Token: 0x06000E43 RID: 3651 RVA: 0x0003AEE0 File Offset: 0x000390E0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 491368, XrefRangeEnd = 491370, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static string Hash128ToStringImpl(Hash128 hash)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref hash;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Hash128.NativeMethodInfoPtr_Hash128ToStringImpl_Private_Static_String_Hash128_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
		}

		// Token: 0x06000E44 RID: 3652 RVA: 0x0003AF18 File Offset: 0x00039118
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 491370, XrefRangeEnd = 491372, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override bool Equals(Object obj)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(obj);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Hash128.NativeMethodInfoPtr_Equals_Public_Virtual_Boolean_Object_0, ref this, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06000E45 RID: 3653 RVA: 0x0003AF5C File Offset: 0x0003915C
		[CallerCount(0)]
		public unsafe bool Equals(Hash128 obj)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref obj;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Hash128.NativeMethodInfoPtr_Equals_Public_Virtual_Final_New_Boolean_Hash128_0, ref this, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06000E46 RID: 3654 RVA: 0x0003AF9C File Offset: 0x0003919C
		[CallerCount(0)]
		public unsafe override int GetHashCode()
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Hash128.NativeMethodInfoPtr_GetHashCode_Public_Virtual_Int32_0, ref this, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06000E47 RID: 3655 RVA: 0x0003AFCC File Offset: 0x000391CC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 491372, XrefRangeEnd = 491374, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe int CompareTo(Object obj)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(obj);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Hash128.NativeMethodInfoPtr_CompareTo_Public_Virtual_Final_New_Int32_Object_0, ref this, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06000E48 RID: 3656 RVA: 0x0003B010 File Offset: 0x00039210
		[CallerCount(0)]
		public unsafe static bool operator ==(Hash128 hash1, Hash128 hash2)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref hash1;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref hash2;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Hash128.NativeMethodInfoPtr_op_Equality_Public_Static_Boolean_Hash128_Hash128_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06000E49 RID: 3657 RVA: 0x0003B05C File Offset: 0x0003925C
		[CallerCount(0)]
		public unsafe static bool operator <(Hash128 x, Hash128 y)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref x;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref y;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Hash128.NativeMethodInfoPtr_op_LessThan_Public_Static_Boolean_Hash128_Hash128_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06000E4A RID: 3658 RVA: 0x0003B0A8 File Offset: 0x000392A8
		[CallerCount(0)]
		public unsafe static bool operator >(Hash128 x, Hash128 y)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref x;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref y;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Hash128.NativeMethodInfoPtr_op_GreaterThan_Public_Static_Boolean_Hash128_Hash128_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06000E4B RID: 3659 RVA: 0x0003B0F4 File Offset: 0x000392F4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 491374, XrefRangeEnd = 491378, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static string Hash128ToStringImpl_Injected(ref Hash128 hash)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = &hash;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Hash128.NativeMethodInfoPtr_Hash128ToStringImpl_Injected_Private_Static_String_byref_Hash128_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
		}

		// Token: 0x06000E4C RID: 3660 RVA: 0x0000991F File Offset: 0x00007B1F
		public Object BoxIl2CppObject()
		{
			return new Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<Hash128>.NativeClassPtr, ref this));
		}

		// Token: 0x1700030D RID: 781
		// (get) Token: 0x06000E4D RID: 3661 RVA: 0x00009931 File Offset: 0x00007B31
		public bool isValid
		{
			get
			{
				return this.u64_0 != 0UL || this.u64_1 > 0UL;
			}
		}

		// Token: 0x06000E4E RID: 3662 RVA: 0x0003B12C File Offset: 0x0003932C
		public static Hash128 Parse(string hashString)
		{
			Hash128 hash;
			Hash128.Parse_Injected(hashString, out hash);
			return hash;
		}

		// Token: 0x06000E4F RID: 3663 RVA: 0x00009948 File Offset: 0x00007B48
		public static void ComputeFromString(string data, ref Hash128 hash)
		{
			Hash128.ComputeFromStringDelegateField(IL2CPP.ManagedStringToIl2Cpp(data), ref hash);
		}

		// Token: 0x06000E50 RID: 3664 RVA: 0x0000995B File Offset: 0x00007B5B
		public static void ComputeFromPtr(IntPtr data, int start, int count, int elemSize, ref Hash128 hash)
		{
			Hash128.ComputeFromPtrDelegateField(data, start, count, elemSize, ref hash);
		}

		// Token: 0x06000E51 RID: 3665 RVA: 0x0000996D File Offset: 0x00007B6D
		public static void ComputeFromArray(Array data, int start, int count, int elemSize, ref Hash128 hash)
		{
			Hash128.ComputeFromArrayDelegateField(IL2CPP.Il2CppObjectBaseToPtr(data), start, count, elemSize, ref hash);
		}

		// Token: 0x06000E52 RID: 3666 RVA: 0x0003B144 File Offset: 0x00039344
		public static Hash128 Compute(string data)
		{
			Hash128 hash = default(Hash128);
			Hash128.ComputeFromString(data, ref hash);
			return hash;
		}

		// Token: 0x06000E53 RID: 3667 RVA: 0x0003B168 File Offset: 0x00039368
		public static Hash128 Compute<T>(Unity.Collections.NativeArray<T> data) where T : struct
		{
			Hash128 hash = default(Hash128);
			Hash128.ComputeFromPtr((IntPtr)data.GetUnsafeReadOnlyPtr<T>(), 0, data.Length, Unity.Collections.LowLevel.Unsafe.UnsafeUtility.SizeOf<T>(), ref hash);
			return hash;
		}

		// Token: 0x06000E54 RID: 3668 RVA: 0x0003B1A4 File Offset: 0x000393A4
		public static Hash128 Compute<T>(Unity.Collections.NativeArray<T> data, int start, int count) where T : struct
		{
			bool flag = start < 0 || count < 0 || start + count > data.Length;
			if (flag)
			{
				throw new ArgumentOutOfRangeException(String.Format("Bad start/count arguments (start:{0} count:{1})", start, count));
			}
			Hash128 hash = default(Hash128);
			Hash128.ComputeFromPtr((IntPtr)data.GetUnsafeReadOnlyPtr<T>(), start, count, Unity.Collections.LowLevel.Unsafe.UnsafeUtility.SizeOf<T>(), ref hash);
			return hash;
		}

		// Token: 0x06000E55 RID: 3669 RVA: 0x0003B210 File Offset: 0x00039410
		public static Hash128 Compute<T>(Il2CppArrayBase<T> data) where T : struct
		{
			bool flag = !Unity.Collections.LowLevel.Unsafe.UnsafeUtility.IsArrayBlittable(data);
			if (flag)
			{
				throw new ArgumentException(String.Concat("Array passed to Compute must be blittable.\n", Unity.Collections.LowLevel.Unsafe.UnsafeUtility.GetReasonForArrayNonBlittable(data)));
			}
			Hash128 hash = default(Hash128);
			Hash128.ComputeFromArray(data, 0, data.Length, Unity.Collections.LowLevel.Unsafe.UnsafeUtility.SizeOf<T>(), ref hash);
			return hash;
		}

		// Token: 0x06000E56 RID: 3670 RVA: 0x0003B264 File Offset: 0x00039464
		public static Hash128 Compute<T>(Il2CppArrayBase<T> data, int start, int count) where T : struct
		{
			bool flag = !Unity.Collections.LowLevel.Unsafe.UnsafeUtility.IsArrayBlittable(data);
			if (flag)
			{
				throw new ArgumentException(String.Concat("Array passed to Compute must be blittable.\n", Unity.Collections.LowLevel.Unsafe.UnsafeUtility.GetReasonForArrayNonBlittable(data)));
			}
			bool flag2 = start < 0 || count < 0 || start + count > data.Length;
			if (flag2)
			{
				throw new ArgumentOutOfRangeException(String.Format("Bad start/count arguments (start:{0} count:{1})", start, count));
			}
			Hash128 hash = default(Hash128);
			Hash128.ComputeFromArray(data, start, count, Unity.Collections.LowLevel.Unsafe.UnsafeUtility.SizeOf<T>(), ref hash);
			return hash;
		}

		// Token: 0x06000E57 RID: 3671 RVA: 0x0003B2EC File Offset: 0x000394EC
		public static Hash128 Compute<T>(List<T> data) where T : struct
		{
			bool flag = !Unity.Collections.LowLevel.Unsafe.UnsafeUtility.IsGenericListBlittable<T>();
			if (flag)
			{
				throw new ArgumentException(String.Format("List<{0}> passed to {1} must be blittable.\n{2}", Type.GetTypeFromHandle(RuntimeReflectionHelper.GetRuntimeTypeHandle<T>()), "Compute", Unity.Collections.LowLevel.Unsafe.UnsafeUtility.GetReasonForGenericListNonBlittable<T>()));
			}
			Hash128 hash = default(Hash128);
			Hash128.ComputeFromArray(NoAllocHelpers.ExtractArrayFromList(data), 0, data.Count, Unity.Collections.LowLevel.Unsafe.UnsafeUtility.SizeOf<T>(), ref hash);
			return hash;
		}

		// Token: 0x06000E58 RID: 3672 RVA: 0x0003B354 File Offset: 0x00039554
		public static Hash128 Compute<T>(List<T> data, int start, int count) where T : struct
		{
			bool flag = !Unity.Collections.LowLevel.Unsafe.UnsafeUtility.IsGenericListBlittable<T>();
			if (flag)
			{
				throw new ArgumentException(String.Format("List<{0}> passed to {1} must be blittable.\n{2}", Type.GetTypeFromHandle(RuntimeReflectionHelper.GetRuntimeTypeHandle<T>()), "Compute", Unity.Collections.LowLevel.Unsafe.UnsafeUtility.GetReasonForGenericListNonBlittable<T>()));
			}
			bool flag2 = start < 0 || count < 0 || start + count > data.Count;
			if (flag2)
			{
				throw new ArgumentOutOfRangeException(String.Format("Bad start/count arguments (start:{0} count:{1})", start, count));
			}
			Hash128 hash = default(Hash128);
			Hash128.ComputeFromArray(NoAllocHelpers.ExtractArrayFromList(data), start, count, Unity.Collections.LowLevel.Unsafe.UnsafeUtility.SizeOf<T>(), ref hash);
			return hash;
		}

		// Token: 0x06000E59 RID: 3673 RVA: 0x0003B3EC File Offset: 0x000395EC
		public unsafe static Hash128 Compute<T>(ref T val) where T : struct, ValueType
		{
			fixed (T* ptr = &val)
			{
				void* ptr2 = (void*)ptr;
				Hash128 hash = default(Hash128);
				Hash128.ComputeFromPtr((IntPtr)ptr2, 0, 1, Unity.Collections.LowLevel.Unsafe.UnsafeUtility.SizeOf<T>(), ref hash);
				return hash;
			}
		}

		// Token: 0x06000E5A RID: 3674 RVA: 0x0003B424 File Offset: 0x00039624
		public static Hash128 Compute(int val)
		{
			Hash128 hash = default(Hash128);
			hash.Append(val);
			return hash;
		}

		// Token: 0x06000E5B RID: 3675 RVA: 0x0003B448 File Offset: 0x00039648
		public static Hash128 Compute(float val)
		{
			Hash128 hash = default(Hash128);
			hash.Append(val);
			return hash;
		}

		// Token: 0x06000E5C RID: 3676 RVA: 0x0003B46C File Offset: 0x0003966C
		public unsafe static Hash128 Compute(void* data, ulong size)
		{
			Hash128 hash = default(Hash128);
			Hash128.ComputeFromPtr(new IntPtr(data), 0, (int)size, 1, ref hash);
			return hash;
		}

		// Token: 0x06000E5D RID: 3677 RVA: 0x00009984 File Offset: 0x00007B84
		public void Append(string data)
		{
			Hash128.ComputeFromString(data, ref this);
		}

		// Token: 0x06000E5E RID: 3678 RVA: 0x0000998F File Offset: 0x00007B8F
		public void Append<T>(Unity.Collections.NativeArray<T> data) where T : struct
		{
			Hash128.ComputeFromPtr((IntPtr)data.GetUnsafeReadOnlyPtr<T>(), 0, data.Length, Unity.Collections.LowLevel.Unsafe.UnsafeUtility.SizeOf<T>(), ref this);
		}

		// Token: 0x06000E5F RID: 3679 RVA: 0x0003B49C File Offset: 0x0003969C
		public void Append<T>(Unity.Collections.NativeArray<T> data, int start, int count) where T : struct
		{
			bool flag = start < 0 || count < 0 || start + count > data.Length;
			if (flag)
			{
				throw new ArgumentOutOfRangeException(String.Format("Bad start/count arguments (start:{0} count:{1})", start, count));
			}
			Hash128.ComputeFromPtr((IntPtr)data.GetUnsafeReadOnlyPtr<T>(), start, count, Unity.Collections.LowLevel.Unsafe.UnsafeUtility.SizeOf<T>(), ref this);
		}

		// Token: 0x06000E60 RID: 3680 RVA: 0x0003B4FC File Offset: 0x000396FC
		public void Append<T>(Il2CppArrayBase<T> data) where T : struct
		{
			bool flag = !Unity.Collections.LowLevel.Unsafe.UnsafeUtility.IsArrayBlittable(data);
			if (flag)
			{
				throw new ArgumentException(String.Concat("Array passed to Append must be blittable.\n", Unity.Collections.LowLevel.Unsafe.UnsafeUtility.GetReasonForArrayNonBlittable(data)));
			}
			Hash128.ComputeFromArray(data, 0, data.Length, Unity.Collections.LowLevel.Unsafe.UnsafeUtility.SizeOf<T>(), ref this);
		}

		// Token: 0x06000E61 RID: 3681 RVA: 0x0003B544 File Offset: 0x00039744
		public void Append<T>(Il2CppArrayBase<T> data, int start, int count) where T : struct
		{
			bool flag = !Unity.Collections.LowLevel.Unsafe.UnsafeUtility.IsArrayBlittable(data);
			if (flag)
			{
				throw new ArgumentException(String.Concat("Array passed to Append must be blittable.\n", Unity.Collections.LowLevel.Unsafe.UnsafeUtility.GetReasonForArrayNonBlittable(data)));
			}
			bool flag2 = start < 0 || count < 0 || start + count > data.Length;
			if (flag2)
			{
				throw new ArgumentOutOfRangeException(String.Format("Bad start/count arguments (start:{0} count:{1})", start, count));
			}
			Hash128.ComputeFromArray(data, start, count, Unity.Collections.LowLevel.Unsafe.UnsafeUtility.SizeOf<T>(), ref this);
		}

		// Token: 0x06000E62 RID: 3682 RVA: 0x0003B5BC File Offset: 0x000397BC
		public void Append<T>(List<T> data) where T : struct
		{
			bool flag = !Unity.Collections.LowLevel.Unsafe.UnsafeUtility.IsGenericListBlittable<T>();
			if (flag)
			{
				throw new ArgumentException(String.Format("List<{0}> passed to {1} must be blittable.\n{2}", Type.GetTypeFromHandle(RuntimeReflectionHelper.GetRuntimeTypeHandle<T>()), "Append", Unity.Collections.LowLevel.Unsafe.UnsafeUtility.GetReasonForGenericListNonBlittable<T>()));
			}
			Hash128.ComputeFromArray(NoAllocHelpers.ExtractArrayFromList(data), 0, data.Count, Unity.Collections.LowLevel.Unsafe.UnsafeUtility.SizeOf<T>(), ref this);
		}

		// Token: 0x06000E63 RID: 3683 RVA: 0x0003B614 File Offset: 0x00039814
		public void Append<T>(List<T> data, int start, int count) where T : struct
		{
			bool flag = !Unity.Collections.LowLevel.Unsafe.UnsafeUtility.IsGenericListBlittable<T>();
			if (flag)
			{
				throw new ArgumentException(String.Format("List<{0}> passed to {1} must be blittable.\n{2}", Type.GetTypeFromHandle(RuntimeReflectionHelper.GetRuntimeTypeHandle<T>()), "Append", Unity.Collections.LowLevel.Unsafe.UnsafeUtility.GetReasonForGenericListNonBlittable<T>()));
			}
			bool flag2 = start < 0 || count < 0 || start + count > data.Count;
			if (flag2)
			{
				throw new ArgumentOutOfRangeException(String.Format("Bad start/count arguments (start:{0} count:{1})", start, count));
			}
			Hash128.ComputeFromArray(NoAllocHelpers.ExtractArrayFromList(data), start, count, Unity.Collections.LowLevel.Unsafe.UnsafeUtility.SizeOf<T>(), ref this);
		}

		// Token: 0x06000E64 RID: 3684 RVA: 0x0003B69C File Offset: 0x0003989C
		public unsafe void Append<T>(ref T val) where T : struct, ValueType
		{
			fixed (T* ptr = &val)
			{
				void* ptr2 = (void*)ptr;
				Hash128.ComputeFromPtr((IntPtr)ptr2, 0, 1, Unity.Collections.LowLevel.Unsafe.UnsafeUtility.SizeOf<T>(), ref this);
			}
		}

		// Token: 0x06000E65 RID: 3685 RVA: 0x000099B1 File Offset: 0x00007BB1
		public void Append(int val)
		{
			this.ShortHash4((uint)val);
		}

		// Token: 0x06000E66 RID: 3686 RVA: 0x000099BC File Offset: 0x00007BBC
		public unsafe void Append(float val)
		{
			this.ShortHash4(*(uint*)(&val));
		}

		// Token: 0x06000E67 RID: 3687 RVA: 0x000099CA File Offset: 0x00007BCA
		public unsafe void Append(void* data, ulong size)
		{
			Hash128.ComputeFromPtr(new IntPtr(data), 0, (int)size, 1, ref this);
		}

		// Token: 0x06000E68 RID: 3688 RVA: 0x0003B6C8 File Offset: 0x000398C8
		public static bool operator !=(Hash128 hash1, Hash128 hash2)
		{
			return !(hash1 == hash2);
		}

		// Token: 0x06000E69 RID: 3689 RVA: 0x0003B6E4 File Offset: 0x000398E4
		public void ShortHash4(uint data)
		{
			ulong num = this.u64_0;
			ulong num2 = this.u64_1;
			ulong num3 = 16045690984833335023UL;
			ulong num4 = 16045690984833335023UL;
			num4 += 288230376151711744UL;
			num3 += (ulong)data;
			Hash128.ShortEnd(ref num, ref num2, ref num3, ref num4);
			this.u64_0 = num;
			this.u64_1 = num2;
		}

		// Token: 0x06000E6A RID: 3690 RVA: 0x0003B744 File Offset: 0x00039944
		public static void ShortEnd(ref ulong h0, ref ulong h1, ref ulong h2, ref ulong h3)
		{
			h3 ^= h2;
			Hash128.Rot64(ref h2, 15);
			h3 += h2;
			h0 ^= h3;
			Hash128.Rot64(ref h3, 52);
			h0 += h3;
			h1 ^= h0;
			Hash128.Rot64(ref h0, 26);
			h1 += h0;
			h2 ^= h1;
			Hash128.Rot64(ref h1, 51);
			h2 += h1;
			h3 ^= h2;
			Hash128.Rot64(ref h2, 28);
			h3 += h2;
			h0 ^= h3;
			Hash128.Rot64(ref h3, 9);
			h0 += h3;
			h1 ^= h0;
			Hash128.Rot64(ref h0, 47);
			h1 += h0;
			h2 ^= h1;
			Hash128.Rot64(ref h1, 54);
			h2 += h1;
			h3 ^= h2;
			Hash128.Rot64(ref h2, 32);
			h3 += h2;
			h0 ^= h3;
			Hash128.Rot64(ref h3, 25);
			h0 += h3;
			h1 ^= h0;
			Hash128.Rot64(ref h0, 63);
			h1 += h0;
		}

		// Token: 0x06000E6B RID: 3691 RVA: 0x000099DE File Offset: 0x00007BDE
		public static void Rot64(ref ulong x, int k)
		{
			x = (x << k) | (x >> 64 - k);
		}

		// Token: 0x06000E6C RID: 3692 RVA: 0x000099F5 File Offset: 0x00007BF5
		public static void Parse_Injected(string hashString, out Hash128 ret)
		{
			Hash128.Parse_InjectedDelegateField(IL2CPP.ManagedStringToIl2Cpp(hashString), out ret);
		}

		// Token: 0x04000A97 RID: 2711
		private static readonly IntPtr NativeFieldInfoPtr_u64_0;

		// Token: 0x04000A98 RID: 2712
		private static readonly IntPtr NativeFieldInfoPtr_u64_1;

		// Token: 0x04000A99 RID: 2713
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_UInt64_UInt64_0;

		// Token: 0x04000A9A RID: 2714
		private static readonly IntPtr NativeMethodInfoPtr_CompareTo_Public_Virtual_Final_New_Int32_Hash128_0;

		// Token: 0x04000A9B RID: 2715
		private static readonly IntPtr NativeMethodInfoPtr_ToString_Public_Virtual_String_0;

		// Token: 0x04000A9C RID: 2716
		private static readonly IntPtr NativeMethodInfoPtr_Hash128ToStringImpl_Private_Static_String_Hash128_0;

		// Token: 0x04000A9D RID: 2717
		private static readonly IntPtr NativeMethodInfoPtr_Equals_Public_Virtual_Boolean_Object_0;

		// Token: 0x04000A9E RID: 2718
		private static readonly IntPtr NativeMethodInfoPtr_Equals_Public_Virtual_Final_New_Boolean_Hash128_0;

		// Token: 0x04000A9F RID: 2719
		private static readonly IntPtr NativeMethodInfoPtr_GetHashCode_Public_Virtual_Int32_0;

		// Token: 0x04000AA0 RID: 2720
		private static readonly IntPtr NativeMethodInfoPtr_CompareTo_Public_Virtual_Final_New_Int32_Object_0;

		// Token: 0x04000AA1 RID: 2721
		private static readonly IntPtr NativeMethodInfoPtr_op_Equality_Public_Static_Boolean_Hash128_Hash128_0;

		// Token: 0x04000AA2 RID: 2722
		private static readonly IntPtr NativeMethodInfoPtr_op_LessThan_Public_Static_Boolean_Hash128_Hash128_0;

		// Token: 0x04000AA3 RID: 2723
		private static readonly IntPtr NativeMethodInfoPtr_op_GreaterThan_Public_Static_Boolean_Hash128_Hash128_0;

		// Token: 0x04000AA4 RID: 2724
		private static readonly IntPtr NativeMethodInfoPtr_Hash128ToStringImpl_Injected_Private_Static_String_byref_Hash128_0;

		// Token: 0x04000AA5 RID: 2725
		[FieldOffset(0)]
		public ulong u64_0;

		// Token: 0x04000AA6 RID: 2726
		[FieldOffset(8)]
		public ulong u64_1;

		// Token: 0x04000AA7 RID: 2727
		public const ulong kConst = 16045690984833335023UL;

		// Token: 0x04000AA8 RID: 2728
		private static readonly Hash128.ComputeFromStringDelegate ComputeFromStringDelegateField;

		// Token: 0x04000AA9 RID: 2729
		private static readonly Hash128.ComputeFromPtrDelegate ComputeFromPtrDelegateField;

		// Token: 0x04000AAA RID: 2730
		private static readonly Hash128.ComputeFromArrayDelegate ComputeFromArrayDelegateField;

		// Token: 0x04000AAB RID: 2731
		private static readonly Hash128.Parse_InjectedDelegate Parse_InjectedDelegateField;

		// Token: 0x0200075C RID: 1884
		// (Invoke) Token: 0x06002CD5 RID: 11477
		private delegate void ComputeFromStringDelegate(IntPtr data, IntPtr hash);

		// Token: 0x0200075D RID: 1885
		// (Invoke) Token: 0x06002CD7 RID: 11479
		private delegate void ComputeFromPtrDelegate(IntPtr data, int start, int count, int elemSize, IntPtr hash);

		// Token: 0x0200075E RID: 1886
		// (Invoke) Token: 0x06002CD9 RID: 11481
		private delegate void ComputeFromArrayDelegate(IntPtr data, int start, int count, int elemSize, IntPtr hash);

		// Token: 0x0200075F RID: 1887
		// (Invoke) Token: 0x06002CDB RID: 11483
		private delegate void Parse_InjectedDelegate(IntPtr hashString, [Out] IntPtr ret);
	}
}
