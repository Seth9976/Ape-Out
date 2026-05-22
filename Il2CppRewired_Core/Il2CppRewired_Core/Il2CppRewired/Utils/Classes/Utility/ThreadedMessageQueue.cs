using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;
using Il2CppSystem.Collections.Generic;

namespace Il2CppRewired.Utils.Classes.Utility
{
	// Token: 0x02000201 RID: 513
	public class ThreadedMessageQueue<T> : Object
	{
		// Token: 0x0600355F RID: 13663 RVA: 0x00109B58 File Offset: 0x00107D58
		// Note: this type is marked as 'beforefieldinit'.
		static ThreadedMessageQueue()
		{
			Il2CppClassPointerStore<ThreadedMessageQueue<T>>.NativeClassPtr = IL2CPP.il2cpp_class_from_type(Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(IL2CPP.GetIl2CppClass("Rewired_Core.dll", "Rewired.Utils.Classes.Utility", "ThreadedMessageQueue`1"))).MakeGenericType(new Il2CppReferenceArray<Type>(new Type[] { Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<T>.NativeClassPtr)) })).TypeHandle.value);
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<ThreadedMessageQueue<T>>.NativeClassPtr);
			ThreadedMessageQueue<T>.NativeFieldInfoPtr_QNDqEsRnZLgpJpMLADQaEeADErp = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ThreadedMessageQueue<T>>.NativeClassPtr, "QNDqEsRnZLgpJpMLADQaEeADErp");
			ThreadedMessageQueue<T>.NativeFieldInfoPtr_frqvHyUIdUlffWfOfdnujaYrTlN = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ThreadedMessageQueue<T>>.NativeClassPtr, "frqvHyUIdUlffWfOfdnujaYrTlN");
			ThreadedMessageQueue<T>.NativeFieldInfoPtr_LnDCUpcsFDXdGdmceKbnXMRSGkiO = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ThreadedMessageQueue<T>>.NativeClassPtr, "LnDCUpcsFDXdGdmceKbnXMRSGkiO");
			ThreadedMessageQueue<T>.NativeFieldInfoPtr_keWkAwdpjRoiHThOXqjduoyMvCn = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ThreadedMessageQueue<T>>.NativeClassPtr, "keWkAwdpjRoiHThOXqjduoyMvCn");
			ThreadedMessageQueue<T>.NativeFieldInfoPtr_EbNjedtgmmFwfTnOvvmSghwMnPZ = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ThreadedMessageQueue<T>>.NativeClassPtr, "EbNjedtgmmFwfTnOvvmSghwMnPZ");
			ThreadedMessageQueue<T>.NativeFieldInfoPtr_egidTKtxQFZHunAkABUicOOREGKB = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ThreadedMessageQueue<T>>.NativeClassPtr, "egidTKtxQFZHunAkABUicOOREGKB");
			ThreadedMessageQueue<T>.NativeFieldInfoPtr_ZpJkFnggwcfhBxKBFtgZDaTYobF = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ThreadedMessageQueue<T>>.NativeClassPtr, "ZpJkFnggwcfhBxKBFtgZDaTYobF");
			ThreadedMessageQueue<T>.NativeFieldInfoPtr_oEZtbKVDQiwNaTKoOIOXEoeGHWQ = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ThreadedMessageQueue<T>>.NativeClassPtr, "oEZtbKVDQiwNaTKoOIOXEoeGHWQ");
			ThreadedMessageQueue<T>.NativeFieldInfoPtr_cyyBkkdxKBBsyXCzMlRPgcvSIBjT = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ThreadedMessageQueue<T>>.NativeClassPtr, "cyyBkkdxKBBsyXCzMlRPgcvSIBjT");
			ThreadedMessageQueue<T>.NativeFieldInfoPtr_EHlHYwlKUGDNpVmkXPJdTmiCPjN = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ThreadedMessageQueue<T>>.NativeClassPtr, "EHlHYwlKUGDNpVmkXPJdTmiCPjN");
			ThreadedMessageQueue<T>.NativeFieldInfoPtr_OGPdMfJpwRsSVAGxJGrPBlthhPYj = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ThreadedMessageQueue<T>>.NativeClassPtr, "OGPdMfJpwRsSVAGxJGrPBlthhPYj");
			ThreadedMessageQueue<T>.NativeMethodInfoPtr__ctor_Public_Void_Int32_Int32_Int32_Boolean_Action_1_T_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ThreadedMessageQueue<T>>.NativeClassPtr, 100676607);
			ThreadedMessageQueue<T>.NativeMethodInfoPtr_Enqueue_Public_Void_T_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ThreadedMessageQueue<T>>.NativeClassPtr, 100676608);
			ThreadedMessageQueue<T>.NativeMethodInfoPtr_addlbLsYdhqtKsbAsBkBewwooiH_Private_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ThreadedMessageQueue<T>>.NativeClassPtr, 100676609);
			ThreadedMessageQueue<T>.NativeMethodInfoPtr_ghRwtMydhLgIeEFZWwEssneMZlc_Private_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ThreadedMessageQueue<T>>.NativeClassPtr, 100676610);
			ThreadedMessageQueue<T>.NativeMethodInfoPtr_wKEgCiGsFuSiwZmRKPAUVGVdlvpx_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ThreadedMessageQueue<T>>.NativeClassPtr, 100676611);
			ThreadedMessageQueue<T>.NativeMethodInfoPtr_khVkVIhFAUMrhObnIwpBwEBgHnb_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ThreadedMessageQueue<T>>.NativeClassPtr, 100676612);
			ThreadedMessageQueue<T>.NativeMethodInfoPtr_Dispose_Public_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ThreadedMessageQueue<T>>.NativeClassPtr, 100676613);
			ThreadedMessageQueue<T>.NativeMethodInfoPtr_Finalize_Protected_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ThreadedMessageQueue<T>>.NativeClassPtr, 100676614);
			ThreadedMessageQueue<T>.NativeMethodInfoPtr_Dispose_Protected_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ThreadedMessageQueue<T>>.NativeClassPtr, 100676615);
		}

		// Token: 0x06003560 RID: 13664 RVA: 0x00109D54 File Offset: 0x00107F54
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 346185, XrefRangeEnd = 346189, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe ThreadedMessageQueue(int maxQueueSize, int threadRefreshRateFPS, int threadAutoKillTimeoutMS, bool threadBlockOnStartAndStop, Action<T> messageReceiverDelegate)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<ThreadedMessageQueue<T>>.NativeClassPtr))
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)5) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref maxQueueSize;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref threadRefreshRateFPS;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref threadAutoKillTimeoutMS;
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref threadBlockOnStartAndStop;
			ptr[checked(unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(messageReceiverDelegate);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ThreadedMessageQueue<T>.NativeMethodInfoPtr__ctor_Public_Void_Int32_Int32_Int32_Boolean_Action_1_T_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06003561 RID: 13665 RVA: 0x00109DD8 File Offset: 0x00107FD8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 346189, XrefRangeEnd = 346194, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Enqueue(T message)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				IntPtr* ptr2 = ptr;
				ref T ptr4;
				if (!typeof(T).IsValueType)
				{
					T t = message;
					if (!(t is string))
					{
						ref T ptr3 = (ptr4 = IL2CPP.Il2CppObjectBaseToPtr(t as Il2CppObjectBase));
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
						ptr4 = IL2CPP.ManagedStringToIl2Cpp(t as string);
					}
				}
				else
				{
					ptr4 = ref message;
				}
				*ptr2 = ref ptr4;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ThreadedMessageQueue<T>.NativeMethodInfoPtr_Enqueue_Public_Void_T_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06003562 RID: 13666 RVA: 0x00109E68 File Offset: 0x00108068
		[CallerCount(0)]
		public unsafe bool addlbLsYdhqtKsbAsBkBewwooiH()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ThreadedMessageQueue<T>.NativeMethodInfoPtr_addlbLsYdhqtKsbAsBkBewwooiH_Private_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06003563 RID: 13667 RVA: 0x00109EA4 File Offset: 0x001080A4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 346194, XrefRangeEnd = 346211, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe bool ghRwtMydhLgIeEFZWwEssneMZlc()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ThreadedMessageQueue<T>.NativeMethodInfoPtr_ghRwtMydhLgIeEFZWwEssneMZlc_Private_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06003564 RID: 13668 RVA: 0x00109EE0 File Offset: 0x001080E0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 346211, XrefRangeEnd = 346221, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void wKEgCiGsFuSiwZmRKPAUVGVdlvpx()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ThreadedMessageQueue<T>.NativeMethodInfoPtr_wKEgCiGsFuSiwZmRKPAUVGVdlvpx_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06003565 RID: 13669 RVA: 0x00109F14 File Offset: 0x00108114
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 346221, XrefRangeEnd = 346230, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void khVkVIhFAUMrhObnIwpBwEBgHnb()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ThreadedMessageQueue<T>.NativeMethodInfoPtr_khVkVIhFAUMrhObnIwpBwEBgHnb_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06003566 RID: 13670 RVA: 0x00109F48 File Offset: 0x00108148
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 346230, XrefRangeEnd = 346235, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual void Dispose()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ThreadedMessageQueue<T>.NativeMethodInfoPtr_Dispose_Public_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06003567 RID: 13671 RVA: 0x00109F7C File Offset: 0x0010817C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 346235, XrefRangeEnd = 346236, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public new unsafe void Finalize()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), ThreadedMessageQueue<T>.NativeMethodInfoPtr_Finalize_Protected_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06003568 RID: 13672 RVA: 0x00109FB8 File Offset: 0x001081B8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 346236, XrefRangeEnd = 346250, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Dispose(bool disposing)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref disposing;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ThreadedMessageQueue<T>.NativeMethodInfoPtr_Dispose_Protected_Void_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06003569 RID: 13673 RVA: 0x000124D4 File Offset: 0x000106D4
		public ThreadedMessageQueue(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x17000FDD RID: 4061
		// (get) Token: 0x0600356A RID: 13674 RVA: 0x00109FF8 File Offset: 0x001081F8
		// (set) Token: 0x0600356B RID: 13675 RVA: 0x000124DD File Offset: 0x000106DD
		public unsafe int QNDqEsRnZLgpJpMLADQaEeADErp
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ThreadedMessageQueue<T>.NativeFieldInfoPtr_QNDqEsRnZLgpJpMLADQaEeADErp);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ThreadedMessageQueue<T>.NativeFieldInfoPtr_QNDqEsRnZLgpJpMLADQaEeADErp)) = value;
			}
		}

		// Token: 0x17000FDE RID: 4062
		// (get) Token: 0x0600356C RID: 13676 RVA: 0x0010A020 File Offset: 0x00108220
		// (set) Token: 0x0600356D RID: 13677 RVA: 0x000124F8 File Offset: 0x000106F8
		public unsafe int frqvHyUIdUlffWfOfdnujaYrTlN
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ThreadedMessageQueue<T>.NativeFieldInfoPtr_frqvHyUIdUlffWfOfdnujaYrTlN);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ThreadedMessageQueue<T>.NativeFieldInfoPtr_frqvHyUIdUlffWfOfdnujaYrTlN)) = value;
			}
		}

		// Token: 0x17000FDF RID: 4063
		// (get) Token: 0x0600356E RID: 13678 RVA: 0x0010A048 File Offset: 0x00108248
		// (set) Token: 0x0600356F RID: 13679 RVA: 0x00012513 File Offset: 0x00010713
		public unsafe int LnDCUpcsFDXdGdmceKbnXMRSGkiO
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ThreadedMessageQueue<T>.NativeFieldInfoPtr_LnDCUpcsFDXdGdmceKbnXMRSGkiO);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ThreadedMessageQueue<T>.NativeFieldInfoPtr_LnDCUpcsFDXdGdmceKbnXMRSGkiO)) = value;
			}
		}

		// Token: 0x17000FE0 RID: 4064
		// (get) Token: 0x06003570 RID: 13680 RVA: 0x0010A070 File Offset: 0x00108270
		// (set) Token: 0x06003571 RID: 13681 RVA: 0x0001252E File Offset: 0x0001072E
		public unsafe bool keWkAwdpjRoiHThOXqjduoyMvCn
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ThreadedMessageQueue<T>.NativeFieldInfoPtr_keWkAwdpjRoiHThOXqjduoyMvCn);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ThreadedMessageQueue<T>.NativeFieldInfoPtr_keWkAwdpjRoiHThOXqjduoyMvCn)) = value;
			}
		}

		// Token: 0x17000FE1 RID: 4065
		// (get) Token: 0x06003572 RID: 13682 RVA: 0x0010A098 File Offset: 0x00108298
		// (set) Token: 0x06003573 RID: 13683 RVA: 0x00012549 File Offset: 0x00010749
		public unsafe ThreadHelper EbNjedtgmmFwfTnOvvmSghwMnPZ
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ThreadedMessageQueue<T>.NativeFieldInfoPtr_EbNjedtgmmFwfTnOvvmSghwMnPZ);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<ThreadHelper>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ThreadedMessageQueue<T>.NativeFieldInfoPtr_EbNjedtgmmFwfTnOvvmSghwMnPZ), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000FE2 RID: 4066
		// (get) Token: 0x06003574 RID: 13684 RVA: 0x0010A0C8 File Offset: 0x001082C8
		// (set) Token: 0x06003575 RID: 13685 RVA: 0x00012568 File Offset: 0x00010768
		public unsafe Queue<T> egidTKtxQFZHunAkABUicOOREGKB
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ThreadedMessageQueue<T>.NativeFieldInfoPtr_egidTKtxQFZHunAkABUicOOREGKB);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Queue<T>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ThreadedMessageQueue<T>.NativeFieldInfoPtr_egidTKtxQFZHunAkABUicOOREGKB), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000FE3 RID: 4067
		// (get) Token: 0x06003576 RID: 13686 RVA: 0x0010A0F8 File Offset: 0x001082F8
		// (set) Token: 0x06003577 RID: 13687 RVA: 0x00012587 File Offset: 0x00010787
		public unsafe Queue<T> ZpJkFnggwcfhBxKBFtgZDaTYobF
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ThreadedMessageQueue<T>.NativeFieldInfoPtr_ZpJkFnggwcfhBxKBFtgZDaTYobF);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Queue<T>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ThreadedMessageQueue<T>.NativeFieldInfoPtr_ZpJkFnggwcfhBxKBFtgZDaTYobF), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000FE4 RID: 4068
		// (get) Token: 0x06003578 RID: 13688 RVA: 0x0010A128 File Offset: 0x00108328
		// (set) Token: 0x06003579 RID: 13689 RVA: 0x000125A6 File Offset: 0x000107A6
		public unsafe bool oEZtbKVDQiwNaTKoOIOXEoeGHWQ
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ThreadedMessageQueue<T>.NativeFieldInfoPtr_oEZtbKVDQiwNaTKoOIOXEoeGHWQ);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ThreadedMessageQueue<T>.NativeFieldInfoPtr_oEZtbKVDQiwNaTKoOIOXEoeGHWQ)) = value;
			}
		}

		// Token: 0x17000FE5 RID: 4069
		// (get) Token: 0x0600357A RID: 13690 RVA: 0x0010A150 File Offset: 0x00108350
		// (set) Token: 0x0600357B RID: 13691 RVA: 0x000125C1 File Offset: 0x000107C1
		public unsafe bool cyyBkkdxKBBsyXCzMlRPgcvSIBjT
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ThreadedMessageQueue<T>.NativeFieldInfoPtr_cyyBkkdxKBBsyXCzMlRPgcvSIBjT);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ThreadedMessageQueue<T>.NativeFieldInfoPtr_cyyBkkdxKBBsyXCzMlRPgcvSIBjT)) = value;
			}
		}

		// Token: 0x17000FE6 RID: 4070
		// (get) Token: 0x0600357C RID: 13692 RVA: 0x0010A178 File Offset: 0x00108378
		// (set) Token: 0x0600357D RID: 13693 RVA: 0x000125DC File Offset: 0x000107DC
		public unsafe Action<T> EHlHYwlKUGDNpVmkXPJdTmiCPjN
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ThreadedMessageQueue<T>.NativeFieldInfoPtr_EHlHYwlKUGDNpVmkXPJdTmiCPjN);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Action<T>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ThreadedMessageQueue<T>.NativeFieldInfoPtr_EHlHYwlKUGDNpVmkXPJdTmiCPjN), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000FE7 RID: 4071
		// (get) Token: 0x0600357E RID: 13694 RVA: 0x0010A1A8 File Offset: 0x001083A8
		// (set) Token: 0x0600357F RID: 13695 RVA: 0x000125FB File Offset: 0x000107FB
		public unsafe bool OGPdMfJpwRsSVAGxJGrPBlthhPYj
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ThreadedMessageQueue<T>.NativeFieldInfoPtr_OGPdMfJpwRsSVAGxJGrPBlthhPYj);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ThreadedMessageQueue<T>.NativeFieldInfoPtr_OGPdMfJpwRsSVAGxJGrPBlthhPYj)) = value;
			}
		}

		// Token: 0x04002D72 RID: 11634
		private static readonly IntPtr NativeFieldInfoPtr_QNDqEsRnZLgpJpMLADQaEeADErp;

		// Token: 0x04002D73 RID: 11635
		private static readonly IntPtr NativeFieldInfoPtr_frqvHyUIdUlffWfOfdnujaYrTlN;

		// Token: 0x04002D74 RID: 11636
		private static readonly IntPtr NativeFieldInfoPtr_LnDCUpcsFDXdGdmceKbnXMRSGkiO;

		// Token: 0x04002D75 RID: 11637
		private static readonly IntPtr NativeFieldInfoPtr_keWkAwdpjRoiHThOXqjduoyMvCn;

		// Token: 0x04002D76 RID: 11638
		private static readonly IntPtr NativeFieldInfoPtr_EbNjedtgmmFwfTnOvvmSghwMnPZ;

		// Token: 0x04002D77 RID: 11639
		private static readonly IntPtr NativeFieldInfoPtr_egidTKtxQFZHunAkABUicOOREGKB;

		// Token: 0x04002D78 RID: 11640
		private static readonly IntPtr NativeFieldInfoPtr_ZpJkFnggwcfhBxKBFtgZDaTYobF;

		// Token: 0x04002D79 RID: 11641
		private static readonly IntPtr NativeFieldInfoPtr_oEZtbKVDQiwNaTKoOIOXEoeGHWQ;

		// Token: 0x04002D7A RID: 11642
		private static readonly IntPtr NativeFieldInfoPtr_cyyBkkdxKBBsyXCzMlRPgcvSIBjT;

		// Token: 0x04002D7B RID: 11643
		private static readonly IntPtr NativeFieldInfoPtr_EHlHYwlKUGDNpVmkXPJdTmiCPjN;

		// Token: 0x04002D7C RID: 11644
		private static readonly IntPtr NativeFieldInfoPtr_OGPdMfJpwRsSVAGxJGrPBlthhPYj;

		// Token: 0x04002D7D RID: 11645
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Int32_Int32_Int32_Boolean_Action_1_T_0;

		// Token: 0x04002D7E RID: 11646
		private static readonly IntPtr NativeMethodInfoPtr_Enqueue_Public_Void_T_0;

		// Token: 0x04002D7F RID: 11647
		private static readonly IntPtr NativeMethodInfoPtr_addlbLsYdhqtKsbAsBkBewwooiH_Private_Boolean_0;

		// Token: 0x04002D80 RID: 11648
		private static readonly IntPtr NativeMethodInfoPtr_ghRwtMydhLgIeEFZWwEssneMZlc_Private_Boolean_0;

		// Token: 0x04002D81 RID: 11649
		private static readonly IntPtr NativeMethodInfoPtr_wKEgCiGsFuSiwZmRKPAUVGVdlvpx_Private_Void_0;

		// Token: 0x04002D82 RID: 11650
		private static readonly IntPtr NativeMethodInfoPtr_khVkVIhFAUMrhObnIwpBwEBgHnb_Private_Void_0;

		// Token: 0x04002D83 RID: 11651
		private static readonly IntPtr NativeMethodInfoPtr_Dispose_Public_Virtual_Final_New_Void_0;

		// Token: 0x04002D84 RID: 11652
		private static readonly IntPtr NativeMethodInfoPtr_Finalize_Protected_Virtual_Void_0;

		// Token: 0x04002D85 RID: 11653
		private static readonly IntPtr NativeMethodInfoPtr_Dispose_Protected_Void_Boolean_0;
	}
}
