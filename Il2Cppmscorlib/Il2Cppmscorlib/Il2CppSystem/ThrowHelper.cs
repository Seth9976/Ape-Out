using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem.Reflection;

namespace Il2CppSystem
{
	// Token: 0x02000050 RID: 80
	public static class ThrowHelper : Object
	{
		// Token: 0x060004DF RID: 1247 RVA: 0x00035D20 File Offset: 0x00033F20
		// Note: this type is marked as 'beforefieldinit'.
		static ThrowHelper()
		{
			Il2CppClassPointerStore<ThrowHelper>.NativeClassPtr = IL2CPP.GetIl2CppClass("mscorlib.dll", "System", "ThrowHelper");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<ThrowHelper>.NativeClassPtr);
			ThrowHelper.NativeMethodInfoPtr_ThrowArgumentNullException_Internal_Static_Void_ExceptionArgument_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ThrowHelper>.NativeClassPtr, 100664010);
			ThrowHelper.NativeMethodInfoPtr_CreateArgumentNullException_Private_Static_Exception_ExceptionArgument_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ThrowHelper>.NativeClassPtr, 100664011);
			ThrowHelper.NativeMethodInfoPtr_ThrowArgumentOutOfRangeException_Internal_Static_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ThrowHelper>.NativeClassPtr, 100664012);
			ThrowHelper.NativeMethodInfoPtr_ThrowWrongValueTypeArgumentException_Internal_Static_Void_Object_Type_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ThrowHelper>.NativeClassPtr, 100664013);
			ThrowHelper.NativeMethodInfoPtr_ThrowArgumentException_Internal_Static_Void_ExceptionResource_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ThrowHelper>.NativeClassPtr, 100664014);
			ThrowHelper.NativeMethodInfoPtr_ThrowArgumentOutOfRangeException_Internal_Static_Void_ExceptionArgument_ExceptionResource_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ThrowHelper>.NativeClassPtr, 100664015);
			ThrowHelper.NativeMethodInfoPtr_ThrowInvalidOperationException_Internal_Static_Void_ExceptionResource_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ThrowHelper>.NativeClassPtr, 100664016);
			ThrowHelper.NativeMethodInfoPtr_ThrowNotSupportedException_Internal_Static_Void_ExceptionResource_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ThrowHelper>.NativeClassPtr, 100664017);
			ThrowHelper.NativeMethodInfoPtr_IfNullAndNullsAreIllegalThenThrow_Internal_Static_Void_Object_ExceptionArgument_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ThrowHelper>.NativeClassPtr, 100664018);
			ThrowHelper.NativeMethodInfoPtr_GetArgumentName_Internal_Static_String_ExceptionArgument_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ThrowHelper>.NativeClassPtr, 100664019);
			ThrowHelper.NativeMethodInfoPtr_GetResourceName_Internal_Static_String_ExceptionResource_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ThrowHelper>.NativeClassPtr, 100664020);
		}

		// Token: 0x060004E0 RID: 1248 RVA: 0x00035E2C File Offset: 0x0003402C
		[CallerCount(10)]
		[CachedScanResults(RefRangeStart = 138569, RefRangeEnd = 138579, XrefRangeStart = 138566, XrefRangeEnd = 138569, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void ThrowArgumentNullException(ExceptionArgument argument)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref argument;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ThrowHelper.NativeMethodInfoPtr_ThrowArgumentNullException_Internal_Static_Void_ExceptionArgument_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x060004E1 RID: 1249 RVA: 0x00035E60 File Offset: 0x00034060
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 138588, RefRangeEnd = 138589, XrefRangeStart = 138579, XrefRangeEnd = 138588, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static Exception CreateArgumentNullException(ExceptionArgument argument)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref argument;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ThrowHelper.NativeMethodInfoPtr_CreateArgumentNullException_Private_Static_Exception_ExceptionArgument_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Exception>(intPtr3) : null;
			}
		}

		// Token: 0x060004E2 RID: 1250 RVA: 0x00035EA0 File Offset: 0x000340A0
		[CallerCount(67)]
		[CachedScanResults(RefRangeStart = 138590, RefRangeEnd = 138657, XrefRangeStart = 138589, XrefRangeEnd = 138590, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void ThrowArgumentOutOfRangeException()
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ThrowHelper.NativeMethodInfoPtr_ThrowArgumentOutOfRangeException_Internal_Static_Void_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060004E3 RID: 1251 RVA: 0x00035EC8 File Offset: 0x000340C8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 138657, XrefRangeEnd = 138673, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void ThrowWrongValueTypeArgumentException(Object value, Type targetType)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(targetType);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ThrowHelper.NativeMethodInfoPtr_ThrowWrongValueTypeArgumentException_Internal_Static_Void_Object_Type_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060004E4 RID: 1252 RVA: 0x00035F10 File Offset: 0x00034110
		[CallerCount(6)]
		[CachedScanResults(RefRangeStart = 138680, RefRangeEnd = 138686, XrefRangeStart = 138673, XrefRangeEnd = 138680, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void ThrowArgumentException(ExceptionResource resource)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref resource;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ThrowHelper.NativeMethodInfoPtr_ThrowArgumentException_Internal_Static_Void_ExceptionResource_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x060004E5 RID: 1253 RVA: 0x00035F44 File Offset: 0x00034144
		[CallerCount(9)]
		[CachedScanResults(RefRangeStart = 138704, RefRangeEnd = 138713, XrefRangeStart = 138686, XrefRangeEnd = 138704, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void ThrowArgumentOutOfRangeException(ExceptionArgument argument, ExceptionResource resource)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref argument;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref resource;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ThrowHelper.NativeMethodInfoPtr_ThrowArgumentOutOfRangeException_Internal_Static_Void_ExceptionArgument_ExceptionResource_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060004E6 RID: 1254 RVA: 0x00035F84 File Offset: 0x00034184
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 138713, XrefRangeEnd = 138720, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void ThrowInvalidOperationException(ExceptionResource resource)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref resource;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ThrowHelper.NativeMethodInfoPtr_ThrowInvalidOperationException_Internal_Static_Void_ExceptionResource_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x060004E7 RID: 1255 RVA: 0x00035FB8 File Offset: 0x000341B8
		[CallerCount(17)]
		[CachedScanResults(RefRangeStart = 138727, RefRangeEnd = 138744, XrefRangeStart = 138720, XrefRangeEnd = 138727, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void ThrowNotSupportedException(ExceptionResource resource)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref resource;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ThrowHelper.NativeMethodInfoPtr_ThrowNotSupportedException_Internal_Static_Void_ExceptionResource_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x060004E8 RID: 1256 RVA: 0x00035FEC File Offset: 0x000341EC
		[CallerCount(0)]
		public unsafe static void IfNullAndNullsAreIllegalThenThrow<T>(Object value, ExceptionArgument argName)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref argName;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ThrowHelper.MethodInfoStoreGeneric_IfNullAndNullsAreIllegalThenThrow_Internal_Static_Void_Object_ExceptionArgument_0<T>.Pointer, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060004E9 RID: 1257 RVA: 0x00036030 File Offset: 0x00034230
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 138770, RefRangeEnd = 138772, XrefRangeStart = 138744, XrefRangeEnd = 138770, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static string GetArgumentName(ExceptionArgument argument)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref argument;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ThrowHelper.NativeMethodInfoPtr_GetArgumentName_Internal_Static_String_ExceptionArgument_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
		}

		// Token: 0x060004EA RID: 1258 RVA: 0x00036068 File Offset: 0x00034268
		[CallerCount(4)]
		[CachedScanResults(RefRangeStart = 138820, RefRangeEnd = 138824, XrefRangeStart = 138772, XrefRangeEnd = 138820, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static string GetResourceName(ExceptionResource resource)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref resource;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ThrowHelper.NativeMethodInfoPtr_GetResourceName_Internal_Static_String_ExceptionResource_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
		}

		// Token: 0x060004EB RID: 1259 RVA: 0x00003E0B File Offset: 0x0000200B
		public ThrowHelper(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x04000386 RID: 902
		private static readonly IntPtr NativeMethodInfoPtr_ThrowArgumentNullException_Internal_Static_Void_ExceptionArgument_0;

		// Token: 0x04000387 RID: 903
		private static readonly IntPtr NativeMethodInfoPtr_CreateArgumentNullException_Private_Static_Exception_ExceptionArgument_0;

		// Token: 0x04000388 RID: 904
		private static readonly IntPtr NativeMethodInfoPtr_ThrowArgumentOutOfRangeException_Internal_Static_Void_0;

		// Token: 0x04000389 RID: 905
		private static readonly IntPtr NativeMethodInfoPtr_ThrowWrongValueTypeArgumentException_Internal_Static_Void_Object_Type_0;

		// Token: 0x0400038A RID: 906
		private static readonly IntPtr NativeMethodInfoPtr_ThrowArgumentException_Internal_Static_Void_ExceptionResource_0;

		// Token: 0x0400038B RID: 907
		private static readonly IntPtr NativeMethodInfoPtr_ThrowArgumentOutOfRangeException_Internal_Static_Void_ExceptionArgument_ExceptionResource_0;

		// Token: 0x0400038C RID: 908
		private static readonly IntPtr NativeMethodInfoPtr_ThrowInvalidOperationException_Internal_Static_Void_ExceptionResource_0;

		// Token: 0x0400038D RID: 909
		private static readonly IntPtr NativeMethodInfoPtr_ThrowNotSupportedException_Internal_Static_Void_ExceptionResource_0;

		// Token: 0x0400038E RID: 910
		private static readonly IntPtr NativeMethodInfoPtr_IfNullAndNullsAreIllegalThenThrow_Internal_Static_Void_Object_ExceptionArgument_0;

		// Token: 0x0400038F RID: 911
		private static readonly IntPtr NativeMethodInfoPtr_GetArgumentName_Internal_Static_String_ExceptionArgument_0;

		// Token: 0x04000390 RID: 912
		private static readonly IntPtr NativeMethodInfoPtr_GetResourceName_Internal_Static_String_ExceptionResource_0;

		// Token: 0x0200054E RID: 1358
		private sealed class MethodInfoStoreGeneric_IfNullAndNullsAreIllegalThenThrow_Internal_Static_Void_Object_ExceptionArgument_0<T>
		{
			// Token: 0x04004073 RID: 16499
			internal static IntPtr Pointer = IL2CPP.il2cpp_method_get_from_reflection(IL2CPP.Il2CppObjectBaseToPtrNotNull(new MethodInfo(IL2CPP.il2cpp_method_get_object(ThrowHelper.NativeMethodInfoPtr_IfNullAndNullsAreIllegalThenThrow_Internal_Static_Void_Object_ExceptionArgument_0, Il2CppClassPointerStore<ThrowHelper>.NativeClassPtr)).MakeGenericMethod(new Il2CppReferenceArray<Type>(new Type[] { Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<T>.NativeClassPtr)) }))));
		}
	}
}
