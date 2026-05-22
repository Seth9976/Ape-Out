using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;

namespace Il2CppSanford.Multimedia.Midi
{
	// Token: 0x02000193 RID: 403
	public sealed class MidiMessageEventHandler : MulticastDelegate
	{
		// Token: 0x06001301 RID: 4865 RVA: 0x00059DDC File Offset: 0x00057FDC
		// Note: this type is marked as 'beforefieldinit'.
		static MidiMessageEventHandler()
		{
			Il2CppClassPointerStore<MidiMessageEventHandler>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp-firstpass.dll", "Sanford.Multimedia.Midi", "MidiMessageEventHandler");
			MidiMessageEventHandler.NativeMethodInfoPtr__ctor_Public_Void_Object_IntPtr_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MidiMessageEventHandler>.NativeClassPtr, 100666051);
			MidiMessageEventHandler.NativeMethodInfoPtr_Invoke_Public_Virtual_New_Void_IMidiMessage_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MidiMessageEventHandler>.NativeClassPtr, 100666052);
			MidiMessageEventHandler.NativeMethodInfoPtr_BeginInvoke_Public_Virtual_New_IAsyncResult_IMidiMessage_AsyncCallback_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MidiMessageEventHandler>.NativeClassPtr, 100666053);
			MidiMessageEventHandler.NativeMethodInfoPtr_EndInvoke_Public_Virtual_New_Void_IAsyncResult_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MidiMessageEventHandler>.NativeClassPtr, 100666054);
		}

		// Token: 0x06001302 RID: 4866 RVA: 0x00059E54 File Offset: 0x00058054
		[CallerCount(42)]
		[CachedScanResults(RefRangeStart = 403, RefRangeEnd = 445, XrefRangeStart = 403, XrefRangeEnd = 445, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe MidiMessageEventHandler(Object @object, IntPtr method)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<MidiMessageEventHandler>.NativeClassPtr))
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(@object);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref method;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MidiMessageEventHandler.NativeMethodInfoPtr__ctor_Public_Void_Object_IntPtr_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06001303 RID: 4867 RVA: 0x00059EB0 File Offset: 0x000580B0
		[CallerCount(99)]
		[CachedScanResults(RefRangeStart = 14114, RefRangeEnd = 14213, XrefRangeStart = 14114, XrefRangeEnd = 14213, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Invoke(IMidiMessage message)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(message);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MidiMessageEventHandler.NativeMethodInfoPtr_Invoke_Public_Virtual_New_Void_IMidiMessage_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06001304 RID: 4868 RVA: 0x00059EF4 File Offset: 0x000580F4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe IAsyncResult BeginInvoke(IMidiMessage message, AsyncCallback callback, Object @object)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(message);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(callback);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(@object);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MidiMessageEventHandler.NativeMethodInfoPtr_BeginInvoke_Public_Virtual_New_IAsyncResult_IMidiMessage_AsyncCallback_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<IAsyncResult>(intPtr3) : null;
		}

		// Token: 0x06001305 RID: 4869 RVA: 0x00059F68 File Offset: 0x00058168
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void EndInvoke(IAsyncResult result)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(result);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MidiMessageEventHandler.NativeMethodInfoPtr_EndInvoke_Public_Virtual_New_Void_IAsyncResult_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06001306 RID: 4870 RVA: 0x00007C8E File Offset: 0x00005E8E
		public MidiMessageEventHandler(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x06001307 RID: 4871 RVA: 0x00007C97 File Offset: 0x00005E97
		public static implicit operator MidiMessageEventHandler(Action<IMidiMessage> A_0)
		{
			return DelegateSupport.ConvertDelegate<MidiMessageEventHandler>(A_0);
		}

		// Token: 0x06001308 RID: 4872 RVA: 0x00007C9F File Offset: 0x00005E9F
		public static MidiMessageEventHandler operator +(MidiMessageEventHandler A_0, MidiMessageEventHandler A_1)
		{
			return Delegate.Combine(A_0, A_1).Cast<MidiMessageEventHandler>();
		}

		// Token: 0x06001309 RID: 4873 RVA: 0x00007CAD File Offset: 0x00005EAD
		public static MidiMessageEventHandler operator -(MidiMessageEventHandler A_0, MidiMessageEventHandler A_1)
		{
			Delegate delegate2;
			Delegate @delegate = (delegate2 = Delegate.Remove(A_0, A_1));
			if (@delegate != null)
			{
				delegate2 = @delegate.Cast<MidiMessageEventHandler>();
			}
			return delegate2;
		}

		// Token: 0x040014D0 RID: 5328
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Object_IntPtr_0;

		// Token: 0x040014D1 RID: 5329
		private static readonly IntPtr NativeMethodInfoPtr_Invoke_Public_Virtual_New_Void_IMidiMessage_0;

		// Token: 0x040014D2 RID: 5330
		private static readonly IntPtr NativeMethodInfoPtr_BeginInvoke_Public_Virtual_New_IAsyncResult_IMidiMessage_AsyncCallback_Object_0;

		// Token: 0x040014D3 RID: 5331
		private static readonly IntPtr NativeMethodInfoPtr_EndInvoke_Public_Virtual_New_Void_IAsyncResult_0;
	}
}
