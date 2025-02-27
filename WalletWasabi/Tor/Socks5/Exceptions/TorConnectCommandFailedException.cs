using System;
using WalletWasabi.Helpers;
using WalletWasabi.Tor.Socks5.Models.Fields.OctetFields;

namespace WalletWasabi.Tor.Socks5.Exceptions
{
	/// <summary>
	/// Thrown when Tor SOCKS5 responds with an error to our <see cref="CmdField.Connect"/> command.
	/// </summary>
	public class TorConnectCommandFailedException : Exception
	{
		public TorConnectCommandFailedException(RepField rep) : base($"Tor SOCKS5 proxy responded with {rep}.")
		{
			RepField = Guard.NotNull(nameof(rep), rep);
		}

		public RepField RepField { get; }
	}
}
