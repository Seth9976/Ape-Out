using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppInterop.Runtime.Runtime;

namespace Il2CppSystem
{
	// Token: 0x02000071 RID: 113
	public sealed class Converter<TInput, TOutput> : MulticastDelegate
	{
		// Token: 0x0600070F RID: 1807 RVA: 0x00042E34 File Offset: 0x00041034
		// Note: this type is marked as 'beforefieldinit'.
		static Converter()
		{
			Il2CppClassPointerStore<Converter<TInput, TOutput>>.NativeClassPtr = IL2CPP.il2cpp_class_from_type(Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(IL2CPP.GetIl2CppClass("mscorlib.dll", "System", "Converter`2"))).MakeGenericType(new Il2CppReferenceArray<Type>(new Type[]
			{
				Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<TInput>.NativeClassPtr)),
				Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<TOutput>.NativeClassPtr))
			})).TypeHandle.value);
			Converter<TInput, TOutput>.NativeMethodInfoPtr__ctor_Public_Void_Object_IntPtr_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Converter<TInput, TOutput>>.NativeClassPtr, 100664405);
			Converter<TInput, TOutput>.NativeMethodInfoPtr_Invoke_Public_Virtual_New_TOutput_TInput_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Converter<TInput, TOutput>>.NativeClassPtr, 100664406);
			Converter<TInput, TOutput>.NativeMethodInfoPtr_BeginInvoke_Public_Virtual_New_IAsyncResult_TInput_AsyncCallback_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Converter<TInput, TOutput>>.NativeClassPtr, 100664407);
			Converter<TInput, TOutput>.NativeMethodInfoPtr_EndInvoke_Public_Virtual_New_TOutput_IAsyncResult_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Converter<TInput, TOutput>>.NativeClassPtr, 100664408);
		}

		// Token: 0x06000710 RID: 1808 RVA: 0x00042EF8 File Offset: 0x000410F8
		[CallerCount(42)]
		[CachedScanResults(RefRangeStart = 403, RefRangeEnd = 445, XrefRangeStart = 403, XrefRangeEnd = 445, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe Converter(Object @object, IntPtr method)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<Converter<TInput, TOutput>>.NativeClassPtr))
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(@object);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref method;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Converter<TInput, TOutput>.NativeMethodInfoPtr__ctor_Public_Void_Object_IntPtr_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000711 RID: 1809 RVA: 0x00042F54 File Offset: 0x00041154
		[CallerCount(10)]
		[CachedScanResults(RefRangeStart = 147104, RefRangeEnd = 147114, XrefRangeStart = 147104, XrefRangeEnd = 147104, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe TOutput Invoke(TInput input)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				IntPtr* ptr2 = ptr;
				ref TInput ptr4;
				if (!typeof(TInput).IsValueType)
				{
					TInput tinput = input;
					if (!(tinput is string))
					{
						ref TInput ptr3 = (ptr4 = IL2CPP.Il2CppObjectBaseToPtr(tinput as Il2CppObjectBase));
						if ((ref ptr3) != null)
						{
							ptr4 = ref ptr3;
							if (IL2CPP.il2cpp_class_is_valuetype(IL2CPP.il2cpp_object_get_class(ref ptr3)))
							{
								ptr4 = IL2CPP.il2cpp_object_unbox(ref ptr3);
							}
						}
					}
					else
					{
						ptr4 = IL2CPP.ManagedStringToIl2Cpp(tinput as string);
					}
				}
				else
				{
					ptr4 = ref input;
				}
				*ptr2 = ref ptr4;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Converter<TInput, TOutput>.NativeMethodInfoPtr_Invoke_Public_Virtual_New_TOutput_TInput_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return IL2CPP.PointerToValueGeneric<TOutput>(intPtr, false, true);
			}
		}

		// Token: 0x06000712 RID: 1810 RVA: 0x00042FEC File Offset: 0x000411EC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe IAsyncResult BeginInvoke(TInput input, AsyncCallback callback, Object @object)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				IntPtr* ptr2 = ptr;
				ref TInput ptr4;
				if (!typeof(TInput).IsValueType)
				{
					TInput tinput = input;
					if (!(tinput is string))
					{
						ref TInput ptr3 = (ptr4 = IL2CPP.Il2CppObjectBaseToPtr(tinput as Il2CppObjectBase));
						if ((ref ptr3) != null)
						{
							ptr4 = ref ptr3;
							if (IL2CPP.il2cpp_class_is_valuetype(IL2CPP.il2cpp_object_get_class(ref ptr3)))
							{
								ptr4 = IL2CPP.il2cpp_object_unbox(ref ptr3);
							}
						}
					}
					else
					{
						ptr4 = IL2CPP.ManagedStringToIl2Cpp(tinput as string);
					}
				}
				else
				{
					ptr4 = ref input;
				}
				*ptr2 = ref ptr4;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(callback);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(@object);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Converter<TInput, TOutput>.NativeMethodInfoPtr_BeginInvoke_Public_Virtual_New_IAsyncResult_TInput_AsyncCallback_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<IAsyncResult>(intPtr3) : null;
		}

		// Token: 0x06000713 RID: 1811 RVA: 0x000430AC File Offset: 0x000412AC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe TOutput EndInvoke(IAsyncResult result)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(result);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Converter<TInput, TOutput>.NativeMethodInfoPtr_EndInvoke_Public_Virtual_New_TOutput_IAsyncResult_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return IL2CPP.PointerToValueGeneric<TOutput>(intPtr, false, true);
			}
		}

		// Token: 0x06000714 RID: 1812 RVA: 0x0000444C File Offset: 0x0000264C
		public Converter(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x06000715 RID: 1813 RVA: 0x00004455 File Offset: 0x00002655
		public static implicit operator Converter<TInput, TOutput>(Func<TInput, TOutput> A_0)
		{
			return DelegateSupport.ConvertDelegate<Converter<TInput, TOutput>>(A_0);
		}

		// Token: 0x06000716 RID: 1814 RVA: 0x0000445D File Offset: 0x0000265D
		public static Converter<TInput, TOutput>operator +(Converter<TInput, TOutput> A_0, Converter<TInput, TOutput> A_1)
		{
			return Delegate.Combine(A_0, A_1).Cast<Converter<TInput, TOutput>>();
		}

		// Token: 0x06000717 RID: 1815 RVA: 0x0000446B File Offset: 0x0000266B
		public static Converter<TInput, TOutput>operator -(Converter<TInput, TOutput> A_0, Converter<TInput, TOutput> A_1)
		{
			Delegate delegate2;
			Delegate @delegate = (delegate2 = Delegate.Remove(A_0, A_1));
			if (@delegate != null)
			{
				delegate2 = @delegate.Cast<Converter<TInput, TOutput>>();
			}
			return delegate2;
		}

		// Token: 0x04000518 RID: 1304
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Object_IntPtr_0;

		// Token: 0x04000519 RID: 1305
		private static readonly IntPtr NativeMethodInfoPtr_Invoke_Public_Virtual_New_TOutput_TInput_0;

		// Token: 0x0400051A RID: 1306
		private static readonly IntPtr NativeMethodInfoPtr_BeginInvoke_Public_Virtual_New_IAsyncResult_TInput_AsyncCallback_Object_0;

		// Token: 0x0400051B RID: 1307
		private static readonly IntPtr NativeMethodInfoPtr_EndInvoke_Public_Virtual_New_TOutput_IAsyncResult_0;
	}
}
