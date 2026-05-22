using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;

namespace Il2CppSystem.Text.RegularExpressions
{
	// Token: 0x0200004C RID: 76
	[Serializable]
	public sealed class MatchEvaluator : MulticastDelegate
	{
		// Token: 0x06000486 RID: 1158 RVA: 0x000228BC File Offset: 0x00020ABC
		// Note: this type is marked as 'beforefieldinit'.
		static MatchEvaluator()
		{
			Il2CppClassPointerStore<MatchEvaluator>.NativeClassPtr = IL2CPP.GetIl2CppClass("System.dll", "System.Text.RegularExpressions", "MatchEvaluator");
			MatchEvaluator.NativeMethodInfoPtr__ctor_Public_Void_Object_IntPtr_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MatchEvaluator>.NativeClassPtr, 100664057);
			MatchEvaluator.NativeMethodInfoPtr_Invoke_Public_Virtual_New_String_Match_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MatchEvaluator>.NativeClassPtr, 100664058);
			MatchEvaluator.NativeMethodInfoPtr_BeginInvoke_Public_Virtual_New_IAsyncResult_Match_AsyncCallback_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MatchEvaluator>.NativeClassPtr, 100664059);
			MatchEvaluator.NativeMethodInfoPtr_EndInvoke_Public_Virtual_New_String_IAsyncResult_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MatchEvaluator>.NativeClassPtr, 100664060);
		}

		// Token: 0x06000487 RID: 1159 RVA: 0x00022934 File Offset: 0x00020B34
		[CallerCount(42)]
		[CachedScanResults(RefRangeStart = 403, RefRangeEnd = 445, XrefRangeStart = 403, XrefRangeEnd = 445, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe MatchEvaluator(Object @object, IntPtr method)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<MatchEvaluator>.NativeClassPtr))
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(@object);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref method;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MatchEvaluator.NativeMethodInfoPtr__ctor_Public_Void_Object_IntPtr_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000488 RID: 1160 RVA: 0x00022990 File Offset: 0x00020B90
		[CallerCount(5)]
		[CachedScanResults(RefRangeStart = 221917, RefRangeEnd = 221922, XrefRangeStart = 221917, XrefRangeEnd = 221922, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe string Invoke(Match match)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(match);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MatchEvaluator.NativeMethodInfoPtr_Invoke_Public_Virtual_New_String_Match_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
		}

		// Token: 0x06000489 RID: 1161 RVA: 0x000229D8 File Offset: 0x00020BD8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe IAsyncResult BeginInvoke(Match match, AsyncCallback callback, Object @object)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(match);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(callback);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(@object);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MatchEvaluator.NativeMethodInfoPtr_BeginInvoke_Public_Virtual_New_IAsyncResult_Match_AsyncCallback_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<IAsyncResult>(intPtr3) : null;
		}

		// Token: 0x0600048A RID: 1162 RVA: 0x00022A4C File Offset: 0x00020C4C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe string EndInvoke(IAsyncResult result)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(result);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MatchEvaluator.NativeMethodInfoPtr_EndInvoke_Public_Virtual_New_String_IAsyncResult_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
		}

		// Token: 0x0600048B RID: 1163 RVA: 0x00003982 File Offset: 0x00001B82
		public MatchEvaluator(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x0600048C RID: 1164 RVA: 0x0000398B File Offset: 0x00001B8B
		public static implicit operator MatchEvaluator(Func<Match, string> A_0)
		{
			return DelegateSupport.ConvertDelegate<MatchEvaluator>(A_0);
		}

		// Token: 0x0600048D RID: 1165 RVA: 0x00003993 File Offset: 0x00001B93
		public static MatchEvaluator operator +(MatchEvaluator A_0, MatchEvaluator A_1)
		{
			return Delegate.Combine(A_0, A_1).Cast<MatchEvaluator>();
		}

		// Token: 0x0600048E RID: 1166 RVA: 0x000039A1 File Offset: 0x00001BA1
		public static MatchEvaluator operator -(MatchEvaluator A_0, MatchEvaluator A_1)
		{
			Delegate delegate2;
			Delegate @delegate = (delegate2 = Delegate.Remove(A_0, A_1));
			if (@delegate != null)
			{
				delegate2 = @delegate.Cast<MatchEvaluator>();
			}
			return delegate2;
		}

		// Token: 0x0400038D RID: 909
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Object_IntPtr_0;

		// Token: 0x0400038E RID: 910
		private static readonly IntPtr NativeMethodInfoPtr_Invoke_Public_Virtual_New_String_Match_0;

		// Token: 0x0400038F RID: 911
		private static readonly IntPtr NativeMethodInfoPtr_BeginInvoke_Public_Virtual_New_IAsyncResult_Match_AsyncCallback_Object_0;

		// Token: 0x04000390 RID: 912
		private static readonly IntPtr NativeMethodInfoPtr_EndInvoke_Public_Virtual_New_String_IAsyncResult_0;
	}
}
