using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using Il2CppInterop.Runtime.Runtime;

namespace Il2CppSystem
{
	// Token: 0x0200012B RID: 299
	[Serializable]
	public class Object : Il2CppObjectBase
	{
		// Token: 0x060015B1 RID: 5553 RVA: 0x000871A8 File Offset: 0x000853A8
		// Note: this type is marked as 'beforefieldinit'.
		static Object()
		{
			Il2CppClassPointerStore<Object>.NativeClassPtr = IL2CPP.GetIl2CppClass("mscorlib.dll", "System", "Object");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<Object>.NativeClassPtr);
			Object.NativeMethodInfoPtr_Equals_Public_Virtual_New_Boolean_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Object>.NativeClassPtr, 100667048);
			Object.NativeMethodInfoPtr_Equals_Public_Static_Boolean_Object_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Object>.NativeClassPtr, 100667049);
			Object.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Object>.NativeClassPtr, 100667050);
			Object.NativeMethodInfoPtr_Finalize_Protected_Virtual_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Object>.NativeClassPtr, 100667051);
			Object.NativeMethodInfoPtr_GetHashCode_Public_Virtual_New_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Object>.NativeClassPtr, 100667052);
			Object.NativeMethodInfoPtr_GetIl2CppType_Public_Type_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Object>.NativeClassPtr, 100667053);
			Object.NativeMethodInfoPtr_MemberwiseClone_Protected_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Object>.NativeClassPtr, 100667054);
			Object.NativeMethodInfoPtr_ToString_Public_Virtual_New_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Object>.NativeClassPtr, 100667055);
			Object.NativeMethodInfoPtr_ReferenceEquals_Public_Static_Boolean_Object_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Object>.NativeClassPtr, 100667056);
			Object.NativeMethodInfoPtr_InternalGetHashCode_Internal_Static_Int32_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Object>.NativeClassPtr, 100667057);
			Object.NativeMethodInfoPtr_FieldGetter_Private_Void_String_String_byref_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Object>.NativeClassPtr, 100667058);
			Object.NativeMethodInfoPtr_FieldSetter_Private_Void_String_String_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Object>.NativeClassPtr, 100667059);
		}

		// Token: 0x060015B2 RID: 5554 RVA: 0x000872C8 File Offset: 0x000854C8
		[CallerCount(0)]
		public unsafe virtual bool Equals(Object obj)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(obj);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), Object.NativeMethodInfoPtr_Equals_Public_Virtual_New_Boolean_Object_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x060015B3 RID: 5555 RVA: 0x00087320 File Offset: 0x00085520
		[CallerCount(0)]
		public unsafe static bool Equals(Object objA, Object objB)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(objA);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(objB);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Object.NativeMethodInfoPtr_Equals_Public_Static_Boolean_Object_Object_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x060015B4 RID: 5556 RVA: 0x00087374 File Offset: 0x00085574
		[CallerCount(7)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 7, XrefRangeStart = 0, XrefRangeEnd = 7, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe Object()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<Object>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Object.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060015B5 RID: 5557 RVA: 0x000873B0 File Offset: 0x000855B0
		[CallerCount(7)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 7, XrefRangeStart = 0, XrefRangeEnd = 7, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Finalize()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), Object.NativeMethodInfoPtr_Finalize_Protected_Virtual_New_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060015B6 RID: 5558 RVA: 0x000873EC File Offset: 0x000855EC
		[CallerCount(0)]
		public unsafe virtual int GetHashCode()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), Object.NativeMethodInfoPtr_GetHashCode_Public_Virtual_New_Int32_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x060015B7 RID: 5559 RVA: 0x00087434 File Offset: 0x00085634
		[CallerCount(22)]
		[CachedScanResults(RefRangeStart = 154834, RefRangeEnd = 154856, XrefRangeStart = 154834, XrefRangeEnd = 154856, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe Type GetIl2CppType()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Object.NativeMethodInfoPtr_GetIl2CppType_Public_Type_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<Type>(intPtr3) : null;
		}

		// Token: 0x060015B8 RID: 5560 RVA: 0x00087474 File Offset: 0x00085674
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe Object MemberwiseClone()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Object.NativeMethodInfoPtr_MemberwiseClone_Protected_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<Object>(intPtr3) : null;
		}

		// Token: 0x060015B9 RID: 5561 RVA: 0x000874B4 File Offset: 0x000856B4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 177200, XrefRangeEnd = 177202, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual string ToString()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), Object.NativeMethodInfoPtr_ToString_Public_Virtual_New_String_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return IL2CPP.Il2CppStringToManaged(intPtr);
		}

		// Token: 0x060015BA RID: 5562 RVA: 0x000874F8 File Offset: 0x000856F8
		[CallerCount(0)]
		public unsafe static bool ReferenceEquals(Object objA, Object objB)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(objA);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(objB);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Object.NativeMethodInfoPtr_ReferenceEquals_Public_Static_Boolean_Object_Object_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x060015BB RID: 5563 RVA: 0x0008754C File Offset: 0x0008574C
		[CallerCount(0)]
		public unsafe static int InternalGetHashCode(Object o)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(o);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Object.NativeMethodInfoPtr_InternalGetHashCode_Internal_Static_Int32_Object_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x060015BC RID: 5564 RVA: 0x00087590 File Offset: 0x00085790
		[CallerCount(7)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 7, XrefRangeStart = 0, XrefRangeEnd = 7, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void FieldGetter(string typeName, string fieldName, ref Object val)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(typeName);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(fieldName);
			ref IntPtr ptr2 = ref ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)];
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtr(val);
			ptr2 = &intPtr;
			IntPtr intPtr3;
			IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(Object.NativeMethodInfoPtr_FieldGetter_Private_Void_String_String_byref_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr3);
			Il2CppException.RaiseExceptionIfNecessary(intPtr3);
			IntPtr intPtr4 = intPtr;
			val = ((intPtr4 == 0) ? null : new Object(intPtr4));
		}

		// Token: 0x060015BD RID: 5565 RVA: 0x0008760C File Offset: 0x0008580C
		[CallerCount(7)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 7, XrefRangeStart = 0, XrefRangeEnd = 7, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void FieldSetter(string typeName, string fieldName, Object val)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(typeName);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(fieldName);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(val);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Object.NativeMethodInfoPtr_FieldSetter_Private_Void_String_String_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060015BE RID: 5566 RVA: 0x000076B6 File Offset: 0x000058B6
		public Object(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x060015BF RID: 5567 RVA: 0x000076BF File Offset: 0x000058BF
		public static implicit operator Object(string A_0)
		{
			return A_0;
		}

		// Token: 0x060015C0 RID: 5568 RVA: 0x00087674 File Offset: 0x00085874
		public static implicit operator Object(sbyte value)
		{
			SByte @sbyte = default(SByte);
			@sbyte.m_value = value;
			return @sbyte.BoxIl2CppObject();
		}

		// Token: 0x060015C1 RID: 5569 RVA: 0x00087698 File Offset: 0x00085898
		public static implicit operator Object(byte value)
		{
			Byte @byte = default(Byte);
			@byte.m_value = value;
			return @byte.BoxIl2CppObject();
		}

		// Token: 0x060015C2 RID: 5570 RVA: 0x000876BC File Offset: 0x000858BC
		public static implicit operator Object(short value)
		{
			Int16 @int = default(Int16);
			@int.m_value = value;
			return @int.BoxIl2CppObject();
		}

		// Token: 0x060015C3 RID: 5571 RVA: 0x000876E0 File Offset: 0x000858E0
		public static implicit operator Object(ushort value)
		{
			UInt16 @uint = default(UInt16);
			@uint.m_value = value;
			return @uint.BoxIl2CppObject();
		}

		// Token: 0x060015C4 RID: 5572 RVA: 0x00087704 File Offset: 0x00085904
		public static implicit operator Object(int value)
		{
			Int32 @int = default(Int32);
			@int.m_value = value;
			return @int.BoxIl2CppObject();
		}

		// Token: 0x060015C5 RID: 5573 RVA: 0x00087728 File Offset: 0x00085928
		public static implicit operator Object(uint value)
		{
			UInt32 @uint = default(UInt32);
			@uint.m_value = value;
			return @uint.BoxIl2CppObject();
		}

		// Token: 0x060015C6 RID: 5574 RVA: 0x0008774C File Offset: 0x0008594C
		public static implicit operator Object(long value)
		{
			Int64 @int = default(Int64);
			@int.m_value = value;
			return @int.BoxIl2CppObject();
		}

		// Token: 0x060015C7 RID: 5575 RVA: 0x00087770 File Offset: 0x00085970
		public static implicit operator Object(ulong value)
		{
			UInt64 @uint = default(UInt64);
			@uint.m_value = value;
			return @uint.BoxIl2CppObject();
		}

		// Token: 0x060015C8 RID: 5576 RVA: 0x00087794 File Offset: 0x00085994
		public static implicit operator Object(float value)
		{
			Single single = default(Single);
			single.m_value = value;
			return single.BoxIl2CppObject();
		}

		// Token: 0x060015C9 RID: 5577 RVA: 0x000877B8 File Offset: 0x000859B8
		public static implicit operator Object(double value)
		{
			Double @double = default(Double);
			@double.m_value = value;
			return @double.BoxIl2CppObject();
		}

		// Token: 0x060015CA RID: 5578 RVA: 0x000877DC File Offset: 0x000859DC
		public static implicit operator Object(char value)
		{
			Char @char = default(Char);
			@char.m_value = value;
			return @char.BoxIl2CppObject();
		}

		// Token: 0x060015CB RID: 5579 RVA: 0x00087800 File Offset: 0x00085A00
		public static implicit operator Object(bool value)
		{
			Boolean boolean = default(Boolean);
			boolean.m_value = value;
			return boolean.BoxIl2CppObject();
		}

		// Token: 0x0400127E RID: 4734
		private static readonly IntPtr NativeMethodInfoPtr_Equals_Public_Virtual_New_Boolean_Object_0;

		// Token: 0x0400127F RID: 4735
		private static readonly IntPtr NativeMethodInfoPtr_Equals_Public_Static_Boolean_Object_Object_0;

		// Token: 0x04001280 RID: 4736
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

		// Token: 0x04001281 RID: 4737
		private static readonly IntPtr NativeMethodInfoPtr_Finalize_Protected_Virtual_New_Void_0;

		// Token: 0x04001282 RID: 4738
		private static readonly IntPtr NativeMethodInfoPtr_GetHashCode_Public_Virtual_New_Int32_0;

		// Token: 0x04001283 RID: 4739
		private static readonly IntPtr NativeMethodInfoPtr_GetIl2CppType_Public_Type_0;

		// Token: 0x04001284 RID: 4740
		private static readonly IntPtr NativeMethodInfoPtr_MemberwiseClone_Protected_Object_0;

		// Token: 0x04001285 RID: 4741
		private static readonly IntPtr NativeMethodInfoPtr_ToString_Public_Virtual_New_String_0;

		// Token: 0x04001286 RID: 4742
		private static readonly IntPtr NativeMethodInfoPtr_ReferenceEquals_Public_Static_Boolean_Object_Object_0;

		// Token: 0x04001287 RID: 4743
		private static readonly IntPtr NativeMethodInfoPtr_InternalGetHashCode_Internal_Static_Int32_Object_0;

		// Token: 0x04001288 RID: 4744
		private static readonly IntPtr NativeMethodInfoPtr_FieldGetter_Private_Void_String_String_byref_Object_0;

		// Token: 0x04001289 RID: 4745
		private static readonly IntPtr NativeMethodInfoPtr_FieldSetter_Private_Void_String_String_Object_0;
	}
}
